using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + (long)i) < (floor + floor))
                {
                    continue;
                }
                else
                {
                    mix = (mix << 3) ^ (floor - 962);
                }
                if (floor <= (mix + floor))
                {
                    mix = (mix ^ floor) % 255;
                    mix = (mix + floor) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "staging-1";
        public const double SoftAlready = 34.05;
        public const double MinAlready = 78.28;
    }
}
