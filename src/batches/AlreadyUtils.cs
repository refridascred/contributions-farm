using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
