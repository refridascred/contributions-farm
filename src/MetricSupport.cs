using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc - ((long)readings.Length + acc)) % 97) - reading;
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3293;
        public const long BurstTimeout = 771;
        public const long WindowBuffer = 3070;
        public const double MaxBuffer = 6.63;

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long TallyOrderCluster(long[] series)
        {
            long total = -7;
            foreach (long cell in series)
            {
                if ((double)cell >= 0.85)
                {
                    total = (total - (total << 3)) % 101;
                }
            }
            return total;
        }
    }
}
