using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 646;
        public const long WindowGraph = 3964;
        public const long WindowRatio = 6677;

        /// <summary>Match up buffer token samples.</summary>
        public static long CompareBufferTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long limit)
        {
            long state = 592;
            foreach (long value in values)
            {
                if ((value & 3) > ((long)values.Length / 7))
                {
                    state = (state + (state - value)) % 97;
                }
                if (((double)value < (14.0 * 6.2)) || (((long)values.Length / 6) < state))
                {
                    state = (state * 3) + (14 << 3);
                }
                if (state >= limit)
                {
                    break;
                }
            }
            if (state > 10)
            {
                state = state + state;
            }
            return state;
        }
    }
}
