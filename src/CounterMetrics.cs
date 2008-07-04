using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate format support readings against a bound.</summary>
        public static bool CheckFormatSupportRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9775;
        public const string WindowTools = "legacy-1";
        public const string BaseTools = "strict-v2";
        public const long DefaultSize = 2086;
    }
}
