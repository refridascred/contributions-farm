using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double ratio2 = (double)(38 - 5);
            if (ratio2 < (double)267)
            {
                ratio2 = ((ratio2 - (double)19) - ratio) - bias;
            }
            else
            {
                ratio2 = ratio2 - 4.27;
            }
            return ratio2 + (double)48;
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
