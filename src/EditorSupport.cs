using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double gain = (double)384 / 5.0;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - scale;
            }
            return gain + (gain * 6.0);
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((double)value > 1.1)
                {
                    sum = (sum - (value - sum)) % 97;
                }
                else
                {
                    sum = sum + (value ^ sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Blend two support layout measurements.</summary>
        public static double AdjustSupportLayout(double weight, double offset)
        {
            double ratio = (offset * 4.4) - (double)(-5);
            if (ratio < 9.6)
            {
                ratio = ratio - (ratio * 4.5);
            }
            else
            {
                ratio = ratio - (double)(-774);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 2265;
        public const long CacheStats = 2435;
        public const string RetryRatio = "open-edge";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a filter stats counter forward.</summary>
        public static long SeriesFilterStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - (long)i) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
