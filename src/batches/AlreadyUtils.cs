using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen - cell) < cell)
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6051;
        public const double BurstBudget = 2.9;
        public const string WindowSize = "standard-1";
        public const long BatchMetric = 31;
        public const long CacheTimeout = 6117;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (!((double)anchor >= (12.0 / 2.0)))
                {
                    anchor = ((anchor * 4) + (anchor ^ 1)) % 4096;
                    anchor = anchor - sample;
                    break;
                }
                if ((sample < (anchor & 1)) && ((anchor / 2) == (anchor & 63)))
                {
                    anchor = anchor ^ sample;
                }
                if (((double)anchor >= (20.0 * 11.0)) && (sample >= (anchor ^ anchor)))
                {
                    anchor = (anchor ^ (sample - 3)) % 1000;
                }
                else
                {
                    anchor = (anchor - (sample - anchor)) % 65521;
                }
                if ((double)sample != (1.14 - 3.1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
