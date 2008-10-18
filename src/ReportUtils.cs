using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const long SoftInterval = 4217;
        public const long BurstSize = 5159;
        public const string MaxBatch = "strict-edge";
        public const long HardBatch = 4644;

        /// <summary>Project the next stream format value.</summary>
        public static double AdjustStreamFormat(double gain, double offset)
        {
            double scale = offset + (offset - 4.1);
            if (scale <= (double)9)
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + offset) - (double)(long)i;
            }
            return scale - (double)2;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (double)(-5) / 2.0;
            if (rate <= (5.48 + scale))
            {
                rate = (rate + (rate - scale)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate / 3.0)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading >> 5) >= (seen * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long bound)
        {
            long lane = seed - bound;
            if (!((bound - 96) < seed))
            {
                return 1;
            }
            else
            {
                if (seed <= (lane - bound))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed + lane))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
