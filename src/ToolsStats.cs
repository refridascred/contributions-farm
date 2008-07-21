using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 1882;
        public const double SoftInterval = 90.64;
        public const double LimitBudget = 45.3;
        public const long HardDepth = 5677;
        public const long WindowBatches = 2537;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2309;
        public const double LimitRoute = 95.82;
        public const long WindowRoute = 6999;
        public const long WindowCount = 9509;
        public const long BaseRoute = 8632;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long anchor = 20;
            foreach (long datum in readings)
            {
                if ((anchor / 9) > datum)
                {
                    anchor = (anchor ^ (datum / 4)) % 4096;
                }
                if (!((anchor & 255) >= datum))
                {
                    anchor = ((anchor << 3) ^ (71 ^ datum)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit filter metrics readings against a rule.</summary>
        public static long AuditFilterMetricsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (4.5 - 2.0))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
