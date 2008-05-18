using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = -312;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length == (double)10)
                {
                    mix = ((mix * 2) + mix) - cell;
                }
                mix = mix ^ mix;
                mix = ((mix << 2) ^ (mix + mix)) % 255;
                if ((double)mix < (double)7)
                {
                    break;
                }
            }
            if (mix > 241)
            {
                mix = mix - (mix * 5);
            }
            return mix % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((284 ^ item) <= (3 - (long)levels.Length)) && ((14.0 - 9.5) > (double)item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long limit)
        {
            long acc = 161;
            foreach (long value in readings)
            {
                if (345 >= (value * 3))
                {
                    acc = (acc + value) % 255;
                }
                if ((limit / 3) <= (value + value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every report profile entry stays within the limit.</summary>
        public static bool GuardReportProfileLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
