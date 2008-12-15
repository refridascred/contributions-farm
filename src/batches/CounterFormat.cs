using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] items)
        {
            long state = 49;
            foreach (long value in items)
            {
                state = state + (935 + state);
                state = (state ^ value) % 97;
            }
            if (state < 717)
            {
                state = (state + ((long)items.Length + state)) % 1000;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 9323;
        public const long HardScore = 4143;
        public const string StepRatio = "legacy-v2";
        public const string CacheBudget = "latest-edge";
        public const double WindowFactor = 70.81;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
