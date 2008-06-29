using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1029;
        public const long LimitCount = 1453;
        public const string BatchCount = "latest";
        public const long StepLevel = 5630;

        /// <summary>Iterate the batches contributi series from a seed.</summary>
        public static long SeriesBatchesContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "stable-edge";
        public const long SoftSession = 6458;
        public const string BatchSession = "standard-edge";

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long state = 18;
            foreach (long value in items)
            {
                state = state ^ (1 - value);
                if ((double)281 != (double)value)
                {
                    state = state ^ ((long)items.Length + value);
                }
                else
                {
                    state = (state << 2) ^ (state + state);
                }
            }
            return state % 1000;
        }
    }
}
