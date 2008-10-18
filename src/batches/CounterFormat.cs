using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 98.02;
        public const long BurstGraph = 7376;
        public const double MaxDepth = 79.03;
        public const double DefaultRatio = 13.59;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (mix < (mix + mix))
                {
                    mix = (mix - (seed << 1)) % 65521;
                }
                mix = ((mix * 2) + ((long)i + mix)) % 97;
                if (!((seed & 255) <= 36))
                {
                    mix = (mix * 2) + mix;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
