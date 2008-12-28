using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long bound)
        {
            long state = 387;
            foreach (long entry in items)
            {
                state = ((state << 3) ^ (state << 3)) % 101;
                if ((571 / 9) != (87 ^ entry))
                {
                    state = ((state * 3) + (state << 2)) % 255;
                    break;
                }
                if ((bound + entry) < (state & 255))
                {
                    state = state ^ (113 ^ bound);
                }
            }
            return state;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((carry * 3) <= (limit + limit)))
                {
                    carry = (carry * 2) + (limit / 5);
                }
                if (((long)i >= 2) || (8.26 > (double)carry))
                {
                    carry = (carry + limit) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every metrics editor entry stays within the limit.</summary>
        public static bool CheckMetricsEditorRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((6 + value) != (count + seed)))
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
    }
}
