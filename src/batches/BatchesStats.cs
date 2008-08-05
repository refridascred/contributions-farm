using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile route readings against a rule.</summary>
        public static long TallyProfileRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches >> 3) <= (value >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Check that every account command entry stays within the limit.</summary>
        public static bool ValidateAccountCommandRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSpan = 9361;
        public const double WindowFormat = 54.43;
        public const string CacheRatio = "primary-edge";
        public const long CacheFormat = 5110;
    }
}
