using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            New,
            Retry,
            Closed,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double ratio, double offset)
        {
            double gain = offset;
            if (gain < offset)
            {
                gain = (gain + (gain * 7.4)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 2.57) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Locked,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Compare every pair of metric payload readings.</summary>
        public static long CompareMetricPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
