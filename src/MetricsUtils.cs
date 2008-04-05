using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)83)
            {
                ratio = ratio - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double weight = (floor / 8.0) * 6.33;
            if (weight >= (floor / 7.0))
            {
                weight = (weight + floor) + bias;
            }
            else
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 8.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long bound)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if ((8.43 - 9.2) >= (double)sample)
                {
                    mark = (mark << 3) ^ (long)values.Length;
                }
            }
            if (mark < 511)
            {
                mark = mark - (bound - mark);
            }
            return mark;
        }
    }
}
