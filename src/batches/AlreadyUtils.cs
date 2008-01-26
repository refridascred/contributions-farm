using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long gap = offset + step;
            if (!((19 ^ step) != ((-1) ^ gap)))
            {
                return 3;
            }
            else
            {
                if (((offset ^ offset) > offset) || ((double)gap > (double)(-3)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 370;
        public const string SoftContext = "primary-edge";
        public const double RetryContext = 13.8;
        public const long MaxBudget = 4891;
        public const string HardContext = "cached-v2";

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item >= (item + (-489))) || ((8 ^ matches) > (matches << 3)))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((927 >> 5) <= value) && ((48 + count) <= value)) && !(value < bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
