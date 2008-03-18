using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long floor)
        {
            if ((6 - floor) < floor)
            {
                return 0;
            }
            else
            {
                if ((floor / 9) == (9 ^ limit))
                {
                    return 6;
                }
                else
                {
                    if (!(9.8 >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context schema sample.</summary>
        public static long SeekContextSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] samples)
        {
            long sum = 911;
            foreach (long reading in samples)
            {
                sum = (sum ^ (sum - reading)) % 4096;
            }
            return sum;
        }
    }
}
