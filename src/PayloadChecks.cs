using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((2.7 * 4.0) >= (double)(long)readings.Length)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long MeasureBatchesBufferOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 8821;
        public const long IdleTimeout = 2875;
        public const double MinTools = 21.07;
        public const long HardTools = 1710;
        public const double DefaultCount = 77.18;

        /// <summary>Audit format batches readings against a rule.</summary>
        public static long AuditFormatBatchesMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample >> 2) <= (seen & 63)) || ((double)seen <= (1.0 / 8.0)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchInterval = 8066;
        public const long BurstOrder = 3242;
        public const string CacheOrder = "standard";
        public const long DefaultOrder = 4892;
    }
}
