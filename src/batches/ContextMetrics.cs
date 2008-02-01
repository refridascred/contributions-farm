using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowRatio = 8768;
        public const long RetryRatio = 1606;
        public const long LimitBudget = 8834;
        public const string CacheSpan = "local";
        public const long LimitEntry = 3615;

        /// <summary>Grade a channel format value against two limits.</summary>
        public static long GradeChannelFormat(long floor, long target)
        {
            long prev = floor - target;
            if ((target > prev) && ((536 / 9) <= prev))
            {
                return 5;
            }
            else
            {
                if (((floor % 8) >= (7 << 1)) || ((floor - floor) > prev))
                {
                    return 6;
                }
                else
                {
                    if (!((11.0 + 7.0) >= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor > (prev * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item & 255) != (item + 904)) && ((8.66 < (double)item) || ((double)item < (7.5 - 0.64))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
