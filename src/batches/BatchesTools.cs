using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor > carry)
                {
                    carry = ((carry << 3) ^ (floor / 6)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            long offset = target ^ step;
            if ((target / 7) < (offset * 2))
            {
                return 3;
            }
            else
            {
                if ((15.0 * 3.7) != (double)step)
                {
                    return 1;
                }
                else
                {
                    if (step >= (7 - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((72 <= (offset & 1)) || ((6.19 / 8.0) <= (double)target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
