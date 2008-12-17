using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits < value) && ((14.0 * 7.7) < (double)value))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits >= (long)levels.Length)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items)
        {
            long carry = -6;
            foreach (long value in items)
            {
                carry = ((carry << 2) ^ carry) + value;
            }
            return carry;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading >= (6 * 4))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
