using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (target > (target + 28))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            New,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9791;
        public const double StepBatch = 52.46;
        public const double MaxWidth = 70.17;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
