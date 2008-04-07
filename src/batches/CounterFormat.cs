using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long total = 2;
            foreach (long item in series)
            {
                total = (((total * 4) + 1) % 101) + item;
            }
            if (total > 6)
            {
                total = (total * 4) + 6;
            }
            return total % 65521;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc << 3) ^ (long)i2;
                    acc = ((acc * 3) + 453) % 101;
                }
                if ((acc >> 3) < (acc - floor))
                {
                    break;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    acc = (acc << 3) ^ ((long)i3 * 4);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
