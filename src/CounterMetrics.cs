using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (double)hits)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate profile already readings against a bound.</summary>
        public static bool VerifyProfileAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
