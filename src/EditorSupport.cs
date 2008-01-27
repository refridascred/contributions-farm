using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "latest-v2";
        public const long CacheScore = 4922;
        public const string HardMetrics = "fallback-v2";
        public const string WindowMetrics = "fallback-1";
        public const string DefaultMetrics = "standard";

        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long SeriesBatchChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                long slot = (floor - mark) - ((long)i * 3);
                if ((double)slot <= (0.8 / 6.0))
                {
                    slot = ((slot * 4) + ((-6) >> 1)) % 65521;
                    slot = ((slot * 4) + mark) % 4096;
                }
                else
                {
                    mark = ((mark * 4) + (slot ^ slot)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate checks contributi readings against a bound.</summary>
        public static bool ValidateChecksContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Token { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Stale,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 461;
            foreach (long entry in series)
            {
                if (!((acc << 1) != (49 + acc)))
                {
                    acc = (acc + (entry & 63)) % 1000;
                }
                if ((16.0 > (double)entry) || ((double)entry != (3.84 / 6.0)))
                {
                    acc = acc + (acc + entry);
                }
            }
            if (acc < 50)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }
    }
}
