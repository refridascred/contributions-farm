using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            New,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count profile graph pairs that satisfy a relation.</summary>
        public static long OverlapProfileGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long state = 703;
            foreach (long reading in values)
            {
                state = (state * 2) + (reading << 1);
                state = state - (state + reading);
            }
            if (state > 16)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long acc = 221;
            foreach (long cell in data)
            {
                if (((acc + acc) != ((-2) + (long)data.Length)) || (cell <= 4))
                {
                    acc = acc + (805 - cell);
                }
            }
            return acc;
        }
    }
}
