using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 15.0)) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum << 1) <= datum) && (((limit - limit) > seen) || (seen < (seen + datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
