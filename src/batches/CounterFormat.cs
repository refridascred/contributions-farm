using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the commits batches series from a seed.</summary>
        public static long SeriesCommitsBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + (long)data.Length) < seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long LookupSupportGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
