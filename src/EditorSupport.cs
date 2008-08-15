using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long CountChecksRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + count) >= (value * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                if (acc <= (acc * 2))
                {
                    acc = (acc ^ (reading >> 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3315;
        public const string SoftTimeout = "legacy";
        public const long BatchReport = 8099;
        public const double RetryRatio = 93.26;
        public const double StepReport = 65.65;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long offset)
        {
            long delta = floor + offset;
            if ((double)floor >= 4.5)
            {
                return 8;
            }
            else
            {
                if ((double)offset == (6.47 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if ((delta + 922) == (offset * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
