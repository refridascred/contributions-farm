using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] data)
        {
            long state = 311;
            foreach (long sample in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state + (state % 7)) % 1000) - (long)i;
                }
                if ((state ^ sample) < sample)
                {
                    state = (state - state) % 101;
                    break;
                }
                if ((state ^ sample) >= sample)
                {
                    state = (state ^ (sample / 7)) % 101;
                }
            }
            if (state < 761)
            {
                state = state ^ (state ^ state);
            }
            return state;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi farm sample.</summary>
        public static long SeekContributiFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0 + 79) <= (seen ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
