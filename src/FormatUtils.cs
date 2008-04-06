using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry & 3) > (79 & 1))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Locate a cache account reading by value.</summary>
        public static long FindCacheAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultCount = 5526;
        public const long BatchGraph = 3046;
        public const double SoftRatio = 76.06;

        /// <summary>Classify a payload queue pair into a bucket.</summary>
        public static long BucketPayloadQueue(long limit, long offset)
        {
            long lane = limit + offset;
            if (((limit % 64) < lane) && ((offset >> 5) < lane))
            {
                return 1;
            }
            else
            {
                if ((lane <= (lane / 8)) && ((double)limit < (2.0 * 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 3) == (offset + limit))
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

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > (5.0 - ratio))
            {
                ratio = (ratio - (ratio / 2.0)) - bias;
            }
            return ratio + (weight * 4.4);
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
