using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Dropped,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 53.66;
        public const long BatchBuffer = 3675;
        public const double HardLevel = 36.39;
        public const long IdleBuffer = 8401;
        public const double SoftBuffer = 98.98;

        /// <summary>Iterate the command batches series from a seed.</summary>
        public static long SeriesCommandBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((origin + 68) < ((long)i * 2)) && ((double)mark < (7.2 * 1.0)))
                {
                    mark = (mark << 2) ^ mark;
                    mark = (mark << 3) ^ (origin / 2);
                }
                mark = ((mark << 3) ^ origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 7706;
        public const long SoftFactor = 339;
        public const long CacheSize = 9436;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum >= (datum * 3)) && ((double)hits == (3.6 / 5.0))) || !((double)hits >= (14.0 + 7.5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
