using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double rate, double bias)
        {
            double gain = bias;
            return (gain + bias) + rate;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data, long offset)
        {
            long sum = 595;
            foreach (long cell in data)
            {
                if ((sum >= 976) || (56 >= (sum + 785)))
                {
                    sum = ((sum << 2) ^ (offset + cell)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7768;
        public const long DefaultChannel = 3976;
        public const long DefaultSpan = 7908;
        public const long MinTimeout = 7870;
        public const long BaseChannel = 8961;
    }
}
