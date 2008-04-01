using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a editor record sample.</summary>
        public static long LookupEditorRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double floor)
        {
            double load = (double)(962 >> 1);
            if (load < (scale - scale))
            {
                load = load - (scale - floor);
            }
            return load - (double)395;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryWidth = 47.24;
        public const long BurstGraph = 6402;
        public const long MinGraph = 2568;
    }
}
