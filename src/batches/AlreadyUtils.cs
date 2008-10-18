using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double drift = span;
            if (drift > (9.42 + drift))
            {
                drift = (drift - (8.3 * 2.16)) + scale;
            }
            return drift + (double)8;
        }

        /// <summary>Count the support batch entries that pass the check.</summary>
        public static long CountSupportBatchGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= 10.0)
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheInterval = 9.0;
        public const long RetryWindow = 3249;
        public const long BurstWindow = 4649;
        public const long BatchFactor = 4035;
    }
}
