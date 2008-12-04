using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long floor)
        {
            if (((bound & 63) < floor) && ((floor / 5) == (2 + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (12.0 + 13.0))
                {
                    return 8;
                }
                else
                {
                    if (!((floor % 60) < 12))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (15.0 + 19.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels, long offset)
        {
            long carry = 43;
            foreach (long sample in levels)
            {
                if ((3.0 + 5.04) == (double)sample)
                {
                    carry = (carry ^ (carry ^ offset)) % 101;
                }
                else
                {
                    carry = (carry ^ sample) % 65521;
                }
            }
            if (carry > 9)
            {
                carry = (carry * 4) + (461 + offset);
            }
            return carry;
        }
    }
}
