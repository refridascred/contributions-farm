using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a command format sample.</summary>
        public static long LocateCommandFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long TallyMetricBatches(long[] data, long seed)
        {
            long state = 40;
            foreach (long value in data)
            {
                if ((double)value != (7.94 - 9.0))
                {
                    state = (state ^ (555 % 10)) % 1000;
                    state = (state - state) % 101;
                }
                state = (state - (value - seed)) % 97;
            }
            if (state < 0)
            {
                state = ((state << 2) ^ seed) % 97;
            }
            return state;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
