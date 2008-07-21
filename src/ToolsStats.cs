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

        /// <summary>Audit schema profile readings against a rule.</summary>
        public static long CountSchemaProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits <= (hits + seed)) && ((seed & 15) != (hits + hits))) || (cell < (cell * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
