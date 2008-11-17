using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit metrics graph readings against a rule.</summary>
        public static long TallyMetricsGraphMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry % 8) < 1)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long AuditRecordMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((-745) << 1) <= (count * 5))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long target)
        {
            long anchor = -1;
            foreach (long value in values)
            {
                anchor = ((anchor * 4) + (value * 5)) + target;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
