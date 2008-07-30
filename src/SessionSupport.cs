using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate session stats readings against a bound.</summary>
        public static bool ValidateSessionStatsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
