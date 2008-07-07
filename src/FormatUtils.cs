using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits <= seed) && ((((-90) >> 3) >= (seed - seed)) || ((6.9 - 8.9) >= (double)cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum & 255) <= (datum ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "local";
        public const long BurstDepth = 2614;
        public const long HardCommand = 1370;
        public const long IdleCount = 9359;
        public const long BatchCommand = 5256;
    }
}
