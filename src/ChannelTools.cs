using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long GradeChecksBuffer(long target, long bound)
        {
            long offset = target - bound;
            if ((bound / 7) != (bound - offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= 5.89)
                {
                    return 2;
                }
                else
                {
                    if (((bound & 63) != (191 - 6)) && (target > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + offset) <= 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values, long target)
        {
            long score = 87;
            foreach (long sample in values)
            {
                if ((4.0 * 9.48) > (double)sample)
                {
                    score = (score + ((long)values.Length * 2)) - target;
                }
            }
            return score;
        }
    }
}
