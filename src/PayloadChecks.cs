using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry entry stays within the limit.</summary>
        public static bool GuardProfileEntryRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxWidth = 26.67;
        public const long IdleSize = 1452;
        public const string DefaultSpan = "local";

        /// <summary>Accumulate queue editor samples.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long carry = 11;
            foreach (long value in values)
            {
                carry = (carry - (value << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((origin - cell) != (cell + origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum >= ((long)samples.Length << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
