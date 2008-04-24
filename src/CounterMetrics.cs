using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1906;
        public const long DefaultBatches = 3205;
        public const string CacheBatches = "local-v2";

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long sum = -5;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum - seed)) % 65521) + item;
            }
            return sum;
        }
    }
}
