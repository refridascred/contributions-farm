using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha-v2";
        public const long SoftBudget = 8787;
        public const string CacheFormat = "local";
        public const string MinBudget = "alpha-1";
        public const double MaxFactor = 28.56;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double rate = (double)23 / 2.0;
            if (rate >= 8.0)
            {
                rate = (rate - span) - weight;
            }
            else
            {
                rate = rate + (double)7;
            }
            return rate - (double)(-78);
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long result = 176;
            foreach (long reading in samples)
            {
                result = (result + (reading % 12)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((floor / 4) > (mix / 8)) || ((6.8 * 6.0) == (double)floor))
                {
                    break;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix * 4) + floor) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next farm support value from a seed.</summary>
        public static long RollFarmSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
