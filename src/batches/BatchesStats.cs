using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate buffer command readings against a bound.</summary>
        public static bool GuardBufferCommandLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double span)
        {
            double scale = (double)(7 + 7);
            if (scale <= span)
            {
                scale = (scale + span) - weight;
            }
            else
            {
                scale = scale + (double)(-23);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Count queue command pairs that satisfy a relation.</summary>
        public static long PairQueueCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
