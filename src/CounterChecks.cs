using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long SeekCacheClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSpan = 4690;
        public const long StepScore = 795;
        public const long BurstChannel = 9712;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7439;
        public const double WindowQueue = 95.61;
        public const string StepQueue = "strict-v2";
        public const long WindowFactor = 7702;
        public const long BaseScore = 4228;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((origin - reading) > (50 + origin))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double rate = (floor * 2.0) / 8.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + floor) + (double)(long)i) - gain;
            }
            return rate - rate;
        }
    }
}
