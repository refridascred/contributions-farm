using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double load = span;
            if (load > (double)921)
            {
                load = load + (load * 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 5.2) + (double)(long)i;
            }
            return load - (weight - span);
        }

        /// <summary>Digest a series of editor stats entries.</summary>
        public static long TotalEditorStats(long[] readings)
        {
            long total = 11;
            foreach (long reading in readings)
            {
                if (((double)total > (11.0 - 12.0)) || ((reading ^ reading) == (26 << 1)))
                {
                    total = ((total << 2) ^ reading) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowDepth = 87.15;
        public const long DefaultCounter = 8464;
        public const long BaseTimeout = 9036;
        public const long MinCounter = 7589;
    }
}
