using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data)
        {
            long score = 46;
            foreach (long value in data)
            {
                score = (score * 5) + (score + value);
            }
            return score % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long limit, long bound)
        {
            if ((bound - bound) < (18 + limit))
            {
                return 5;
            }
            else
            {
                if ((3.93 + 9.4) != (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (7.0 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound ^ limit) < (-376))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long TotalSchemaAlready(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                sum = (sum + (sample >> 1)) % 1000;
            }
            if (sum > (-426))
            {
                sum = sum + (offset * 2);
            }
            return sum;
        }
    }
}
