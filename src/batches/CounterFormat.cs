using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 80.35;
        public const long BurstLayout = 4773;
        public const long LimitLayout = 5003;
        public const long DefaultLayout = 1144;

        /// <summary>Look up the position of a session schema sample.</summary>
        public static long SeekSessionSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double floor)
        {
            double mean = floor;
            return (mean + 3.7) + ratio;
        }
    }
}
