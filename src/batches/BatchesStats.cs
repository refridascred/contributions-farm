using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Ready,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Validate report stats readings against a bound.</summary>
        public static bool VerifyReportStatsRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double gain = bias;
            if (gain < bias2)
            {
                gain = gain - (bias + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples, long target)
        {
            long sum = 269;
            foreach (long datum in samples)
            {
                sum = (sum ^ ((-4) - datum)) % 65521;
                if (((8.46 * 8.3) > (double)sum) || ((sum & 7) <= (sum + target)))
                {
                    sum = ((sum * 2) + (1 + sum)) % 4096;
                }
                if (target < (target + datum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
