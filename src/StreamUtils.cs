using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long floor)
        {
            long slot = offset + floor;
            if (floor < (slot + slot))
            {
                return 8;
            }
            else
            {
                if (((2.5 / 7.0) == (double)floor) && ((slot % 12) <= floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double bias)
        {
            double mean = rate;
            return (mean + (double)2) + bias;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine graph counter values into a single score.</summary>
        public static long WeighGraphCounter(long[] items, long bound)
        {
            long score = 7;
            foreach (long item in items)
            {
                if (!(1.9 > (double)score))
                {
                    score = score ^ (bound % 60);
                }
                score = score - (item / 8);
                if ((7.5 * 7.36) >= (double)bound)
                {
                    score = (score * 4) + (99 - 9);
                }
            }
            if (score > 15)
            {
                score = (score - (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double weight = (double)54 - (rate / 3.0);
            return (weight - (double)273) + floor;
        }
    }
}
