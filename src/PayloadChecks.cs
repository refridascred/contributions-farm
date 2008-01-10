using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ ((long)i >> 2)) % 4096;
                mix = (mix - (long)i) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a stats commits reading by value.</summary>
        public static long FindStatsCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double gain = (double)(6 << 1);
            if (gain < (double)364)
            {
                gain = gain + (ratio + 1.03);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (bias - bias)) + (double)(long)i;
            }
            return gain + (ratio + 7.6);
        }

        /// <summary>Locate a metric stats reading by value.</summary>
        public static long LocateMetricStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
