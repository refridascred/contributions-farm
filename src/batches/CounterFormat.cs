using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long floor)
        {
            long step = target + floor;
            if ((target << 1) >= (target + floor))
            {
                return 4;
            }
            else
            {
                if ((step % 3) < (49 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) < (247 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 3) ^ (floor + total)) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
