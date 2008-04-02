using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long SeekEntryTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm cluster samples.</summary>
        public static long CompareGithubfarmClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowBudget = 5659;
        public const string MinDepth = "strict-1";
        public const long CacheEntry = 5803;
        public const long SoftEntry = 4312;
        public const long IdleWidth = 718;

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values)
        {
            long state = 1;
            foreach (long entry in values)
            {
                if (entry < (state + state))
                {
                    state = state - entry;
                }
            }
            if (state > 0)
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }
    }
}
