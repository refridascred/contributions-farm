using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long seed)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if (!(((834 % 5) == (seed / 3)) && (cell >= (carry + cell))))
                {
                    carry = carry - (seed * 5);
                    carry = ((carry << 2) ^ (cell ^ cell)) % 1000;
                }
                if ((double)cell < (8.1 - 1.0))
                {
                    carry = ((carry * 5) + seed) % 4096;
                }
            }
            if (carry > 0)
            {
                carry = (carry ^ (long)levels.Length) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a account cache reading.</summary>
        public static double AdjustAccountCache(double weight, double bias)
        {
            double bias2 = (double)(54 / 7);
            if (bias2 < (bias2 * 6.0))
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 - bias2;
        }

        /// <summary>Find the first layout buffer entry that matches the target.</summary>
        public static long LookupLayoutBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long AuditLayoutWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count >= (count >> 5))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long step)
        {
            if (((bound / 9) != (4 + step)) || ((double)step <= (1.0 / 6.0)))
            {
                return 8;
            }
            else
            {
                if ((step + 713) != (step * 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound ^ bound) < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound << 3) == (step / 7)) || ((bound + 500) >= (step - bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
