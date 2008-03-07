using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((6.0 / 5.0) <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate tools graph readings against a bound.</summary>
        public static bool CheckToolsGraphLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string SoftBuffer = "stable";
        public const long BaseBuffer = 9368;
        public const string RetryBuffer = "alpha-1";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long step)
        {
            long diff = floor ^ step;
            if (((diff + floor) <= 284) && ((diff - diff) == (449 * 4)))
            {
                return 4;
            }
            else
            {
                if (((diff - 26) <= (25 - floor)) || (floor >= step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
