using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double bias = 2.28;
            if (bias < (double)80)
            {
                bias = (bias + (double)961) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias - span)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double load = offset / 2.0;
            if (load <= (double)171)
            {
                load = load - (load + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (scale - load);
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long bound)
        {
            if ((9.0 / 9.0) == (double)offset)
            {
                return 8;
            }
            else
            {
                if ((25 ^ 3) > (offset * 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
