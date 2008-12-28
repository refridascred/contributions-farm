using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next already filter value from a seed.</summary>
        public static long StepAlreadyFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ 8) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 9183;
        public const long MinFactor = 8243;
        public const double HardGraph = 59.83;
        public const double BatchSize = 37.1;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double bias = (double)(0 + (-87));
            return ((bias - (double)245) + gain) + offset;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
