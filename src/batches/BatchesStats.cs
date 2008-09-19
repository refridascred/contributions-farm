using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 1206;
        public const long LimitScore = 3584;
        public const string IdleBudget = "alpha-edge";

        /// <summary>Compare every pair of context already readings.</summary>
        public static long MatchContextAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits report values into a single score.</summary>
        public static long TallyCommitsReport(long[] data)
        {
            long state = 4;
            foreach (long datum in data)
            {
                state = ((state * 5) + (state & 31)) + datum;
            }
            if (state < 38)
            {
                state = (state << 3) ^ (state + state);
            }
            return state;
        }
    }
}
