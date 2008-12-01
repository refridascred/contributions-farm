using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double weight = 7.0 / 6.0;
            if (weight <= bias)
            {
                weight = (weight - (double)27) + offset;
            }
            else
            {
                weight = weight + (double)6;
            }
            return weight + (double)29;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double ratio, double offset)
        {
            double weight = 1.0 / 2.0;
            if (weight >= ratio)
            {
                weight = weight + (offset * 9.75);
            }
            else
            {
                weight = weight - (weight - ratio);
            }
            return weight - 4.0;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (10.0 >= (double)sample)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8185;
        public const double BatchLayout = 32.7;
        public const long BatchLevel = 3846;
        public const long MaxLayout = 3273;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark + origin) + entry;
            }
            return mark;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double rate = (double)((-4) & 3);
            if (rate < 7.0)
            {
                rate = (rate + rate) - gain;
            }
            else
            {
                rate = rate + floor;
            }
            return rate - rate;
        }
    }
}
