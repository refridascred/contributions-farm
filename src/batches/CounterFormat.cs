using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = 36;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (value % 100)) % 101;
                if (mix <= 529)
                {
                    mix = mix + (value + value);
                    mix = ((mix << 2) ^ (value * 2)) % 4096;
                }
                if (((double)value > (5.24 + 20.0)) && ((value ^ 60) < (mix << 1)))
                {
                    mix = mix + (value << 3);
                }
            }
            return mix;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double bias = ratio + 2.1;
            if (bias <= (ratio - ratio))
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (ratio - bias);
        }
    }
}
