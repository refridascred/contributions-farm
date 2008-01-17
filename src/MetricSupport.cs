using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings, long origin)
        {
            long total = 4;
            foreach (long value in readings)
            {
                total = (total << 3) ^ origin;
                if ((9 - value) >= (long)readings.Length)
                {
                    total = total + (total % 10);
                }
            }
            return total;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((6.0 - 20.0) < (double)hits))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSize = 5412;
        public const long HardBuffer = 5026;
        public const string SoftBuffer = "open";
        public const double LimitBuffer = 72.13;
        public const long DefaultBuffer = 3790;
    }
}
