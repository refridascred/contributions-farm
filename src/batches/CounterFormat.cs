using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor >> 3) <= total)
                {
                    total = (total << 2) ^ (floor - (-27));
                    total = (total ^ (floor % 8)) % 4096;
                }
                if (((long)i * 3) == (floor + floor))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias2 / 8.0))
            {
                bias2 = bias2 + (bias2 / 7.0);
            }
            else
            {
                bias2 = bias2 + scale;
            }
            return bias2 - (19.0 - 13.0);
        }
    }
}
