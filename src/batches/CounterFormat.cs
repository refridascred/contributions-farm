using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long bound, long seed)
        {
            long slot = bound - seed;
            if (!((bound * 5) == (slot + slot)))
            {
                return 3;
            }
            else
            {
                if (!((double)bound != (4.7 - 3.8)))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 3) > slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
