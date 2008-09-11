using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double gain, double bias)
        {
            double ratio = 1.1 + (gain * 0.76);
            if (ratio > bias)
            {
                ratio = ratio + (double)69;
            }
            return ratio - (ratio * 3.0);
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long mix = 267;
            foreach (long cell in samples)
            {
                if ((long)samples.Length > ((long)samples.Length + mix))
                {
                    mix = (mix ^ 795) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Derive the next layout buffer value from a seed.</summary>
        public static long RollLayoutBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc - (3 + (long)i2)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
