using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double mean = (double)(276 >> 3);
            if (mean < 7.9)
            {
                mean = (mean + floor) + ratio;
            }
            return mean - floor;
        }

        /// <summary>Audit session batches readings against a rule.</summary>
        public static long MeasureSessionBatchesHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((bound < value) && ((double)tally == (double)bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitTimeout = 4146;
        public const double HardLevel = 95.83;
        public const long LimitCluster = 5476;
        public const long HardCluster = 4664;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
