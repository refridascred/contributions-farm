using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items, long bound)
        {
            long mix = 22;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ (item + item)) % 1000;
            }
            if (mix > 26)
            {
                mix = mix - bound;
            }
            return mix % 65521;
        }

        /// <summary>Check that every command queue entry stays within the limit.</summary>
        public static bool ValidateCommandQueueBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
