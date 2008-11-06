using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a checks contributi reading by value.</summary>
        public static long LookupChecksContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstWidth = 5818;
        public const long RetryDepth = 6755;
        public const long MinTimeout = 5260;

        /// <summary>Adjust a record queue reading.</summary>
        public static double ScaleRecordQueue(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > (floor - gain))
            {
                gain2 = gain2 - (double)48;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (8.3 - gain)) + (double)(long)i;
            }
            return gain2 - gain2;
        }
    }
}
