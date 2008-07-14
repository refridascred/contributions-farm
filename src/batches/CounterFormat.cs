using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double ratio = 18.0;
            if (ratio < (2.4 / 8.0))
            {
                ratio = (ratio - gain) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 9.12) - (double)(long)i;
            }
            return ratio + (double)(-303);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
