using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long floor)
        {
            if ((bound - floor) == (floor - bound))
            {
                return 7;
            }
            else
            {
                if (!((floor + bound) > (floor / 2)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound < (double)98) || ((17.0 - 2.86) >= (double)floor))
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

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches entry values into a single score.</summary>
        public static long TallyBatchesEntry(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long datum in samples)
            {
                sum = (sum << 2) ^ bound;
                if (bound > datum)
                {
                    sum = sum ^ (908 % 64);
                }
            }
            if (sum < 426)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }
    }
}
