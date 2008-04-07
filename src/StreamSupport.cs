using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
