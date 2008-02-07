using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double offset)
        {
            double drift = rate + rate;
            return (drift + drift) + offset;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ seed) % 101) - (long)i2;
                }
                result = (result << 2) ^ (seed ^ result);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Idle,
            Queued,
            Locked,
        }
    }
}
