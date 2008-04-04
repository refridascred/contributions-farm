using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long state = 6;
            foreach (long item in values)
            {
                if (((98 / 2) != (item >> 4)) || ((double)state == (2.9 / 8.0)))
                {
                    state = ((state * 5) + (item & 63)) % 4096;
                }
                if ((double)311 >= (double)(long)values.Length)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5183;
        public const string IdleScore = "alpha-v2";
        public const double RetryBatches = 47.22;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBudget = "open";
        public const long HardBatch = 9200;
        public const long SoftInterval = 9586;
    }
}
