using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double rate = (double)(5 >> 1);
            if (rate <= (floor * 20.0))
            {
                rate = (rate + rate) - scale;
            }
            return rate - 20.0;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 2387;
        public const string SoftTimeout = "legacy-v2";
        public const string DefaultScore = "latest-edge";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (seed - mix)) % 97;
                mix = ((mix * 3) + seed) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
