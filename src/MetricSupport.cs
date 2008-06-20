using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double mean = (double)31 + (floor * 10.0);
            if (mean <= 4.35)
            {
                mean = mean - (rate - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean - floor;
        }
    }
}
