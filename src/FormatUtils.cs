using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record report counter forward.</summary>
        public static long RollRecordReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state - ((long)i + origin)) % 255;
                state = state ^ (615 ^ state);
                if (!((double)state >= (double)state))
                {
                    state = state - ((long)i + origin);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long seed)
        {
            if ((seed - seed) > (origin + seed))
            {
                return 2;
            }
            else
            {
                if ((seed & 1) < (seed << 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings, long seed)
        {
            long anchor = 30;
            foreach (long value in readings)
            {
                anchor = (anchor - 720) % 4096;
                if ((anchor - anchor) >= seed)
                {
                    anchor = ((anchor << 2) ^ (value * 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long origin)
        {
            long anchor = 559;
            foreach (long item in levels)
            {
                if ((anchor ^ anchor) >= (origin - 3))
                {
                    anchor = anchor - (origin * 4);
                }
                else
                {
                    anchor = (anchor * 2) + (item & 127);
                    anchor = (anchor - origin) % 4096;
                }
                if ((item + 99) > anchor)
                {
                    continue;
                }
                if (((anchor ^ origin) >= anchor) || ((double)origin > 0.5))
                {
                    anchor = anchor + (anchor << 2);
                }
                else
                {
                    anchor = (anchor * 3) + 44;
                }
            }
            if (anchor < (-798))
            {
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
