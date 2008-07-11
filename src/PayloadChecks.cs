using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((item << 1) != (seen % 16)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 68) >= (hits % 3))
                {
                    hits = ((hits + 1) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "legacy";
        public const string MinContributi = "fallback-v2";
        public const long CacheContributi = 5760;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double scale = rate + (double)732;
            if (scale >= (double)0)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (rate - rate);
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
