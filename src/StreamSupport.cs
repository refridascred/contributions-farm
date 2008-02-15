using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double gain = 6.22;
            if (gain <= (double)(-37))
            {
                gain = (gain + (floor * 2.89)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain / 6.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitTimeout = 9509;
        public const string WindowSchema = "standard-edge";
        public const long CacheSchema = 2856;
        public const long BaseRatio = 8024;
    }
}
