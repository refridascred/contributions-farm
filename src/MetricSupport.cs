using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two token filter measurements.</summary>
        public static double BlendTokenFilter(double weight, double span)
        {
            double drift = (double)(248 + 341);
            if (drift > drift)
            {
                drift = (drift + 9.4) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (4.94 / 2.0);
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double offset)
        {
            double mean = rate;
            return (mean + (7.12 * 5.0)) + offset;
        }
    }
}
