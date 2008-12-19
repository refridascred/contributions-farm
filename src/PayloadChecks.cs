using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor ^ (49 >> 2)) % 1000) ^ item;
                if ((anchor - anchor) < ((long)items.Length / 9))
                {
                    anchor = anchor ^ (-258);
                }
                if ((double)anchor >= (double)13)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double span)
        {
            double gain = span;
            return (gain + gain) + bias;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((floor - 26) >= (floor << 2))
                {
                    total = (total ^ (352 % 3)) % 101;
                    total = (total - (floor - (long)i)) % 101;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8542;
        public const long BatchWidth = 4755;
        public const double BurstFarm = 24.02;
        public const long SoftWidth = 3851;

        /// <summary>Digest a series of context buffer entries.</summary>
        public static long WeighContextBuffer(long[] samples)
        {
            long mix = 208;
            foreach (long sample in samples)
            {
                mix = (mix + 45) + sample;
                if (57 < (mix + 590))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 84.51;
        public const long BaseSpan = 84;
        public const long StepFactor = 3090;
        public const string SoftProfile = "standard";
    }
}
