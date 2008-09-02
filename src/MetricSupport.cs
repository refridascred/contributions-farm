using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool ValidateContextCommandLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
