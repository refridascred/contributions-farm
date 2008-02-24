using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 9851;
        public const long RetryToken = 6472;
        public const long StepTimeout = 2405;
        public const long DefaultFactor = 2449;

        /// <summary>Fold a list of queue record readings.</summary>
        public static long TotalQueueRecord(long[] levels)
        {
            long score = 825;
            foreach (long cell in levels)
            {
                score = (((score << 2) ^ 68) % 255) - cell;
            }
            if (score > 51)
            {
                score = (score * 3) + (score % 64);
            }
            return score % 1000;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
