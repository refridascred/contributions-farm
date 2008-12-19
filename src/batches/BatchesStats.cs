using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count ^ cell) > (count ^ count)) && ((count + cell) >= (count - cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long step2)
        {
            if ((step * 3) != (22 / 5))
            {
                return 6;
            }
            else
            {
                if (((double)step <= (5.19 - 4.0)) || ((4.48 / 8.0) != (double)step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry << 2) ^ (carry + carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
