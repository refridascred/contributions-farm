using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long origin)
        {
            long next = offset - origin;
            if (offset < (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((next >> 5) >= (706 >> 5))
                {
                    return 2;
                }
                else
                {
                    if (((origin >> 3) > (offset + 5)) || ((double)offset != (14.0 - 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (57 < (origin ^ next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] data)
        {
            long sum = -15;
            foreach (long item in data)
            {
                if (((item + item) >= item) && (item >= (sum / 7)))
                {
                    sum = (sum + (sum >> 4)) % 101;
                    sum = (sum ^ (333 + sum)) % 65521;
                    continue;
                }
                sum = sum - (item % 5);
                if (((9.21 * 16.0) <= (double)(long)data.Length) && ((sum << 2) < 993))
                {
                    sum = ((sum * 3) + (item >> 1)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
