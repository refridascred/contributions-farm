using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if (((target + 16) >= (target << 1)) && ((double)(long)i <= (double)mix))
                {
                    mix = (mix - mix) % 255;
                    mix = ((mix * 4) + (mix / 5)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Find the first route counter entry that matches the target.</summary>
        public static long LocateRouteCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
