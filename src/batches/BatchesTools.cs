using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long offset)
        {
            long prev = bound ^ offset;
            if ((offset / 6) <= prev)
            {
                return 8;
            }
            else
            {
                if (!((633 + offset) == (prev + 284)))
                {
                    return 5;
                }
                else
                {
                    if ((offset + bound) != (offset % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((29 + prev) < (prev << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long AuditMetricsQueueHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((item % 64) <= (hits ^ hits)) || (item > (2 * 3)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry * 3) + (40 << 3);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
