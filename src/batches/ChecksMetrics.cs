using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string IdleWidth = "strict";
        public const long SoftSpan = 6167;
        public const string HardWidth = "primary-v2";
        public const long WindowLevel = 3958;

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long target)
        {
            if ((1.0 >= (double)target) || ((4.0 / 7.0) < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 1) >= origin)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the profile stream entries that pass the check.</summary>
        public static long TallyProfileStreamMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (5 >= (seed ^ 512))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((3.28 - 8.96) >= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool GuardBufferCounterLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc + (acc << 2)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
