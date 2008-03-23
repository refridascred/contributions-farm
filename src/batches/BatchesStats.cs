using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-1";
        public const string BurstCluster = "primary";
        public const long WindowScore = 3323;
        public const long SoftBudget = 2403;
        public const long RetryCluster = 708;

        /// <summary>Combine support contributi values into a single score.</summary>
        public static long CombineSupportContributi(long[] items, long origin)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((mix + origin) > (long)items.Length)
                {
                    mix = (mix - (mix * 3)) - reading;
                    mix = (mix ^ (9 >> 2)) % 101;
                }
                mix = ((mix << 3) ^ (mix + origin)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long offset)
        {
            if ((767 - offset) > (floor + floor))
            {
                return 1;
            }
            else
            {
                if (16.0 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset > 2.4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double span)
        {
            double scale = span / 6.0;
            if (scale <= span)
            {
                scale = (scale + span) - rate;
            }
            else
            {
                scale = scale + span;
            }
            return scale - span;
        }
    }
}
