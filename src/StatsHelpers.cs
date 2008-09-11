using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Done,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
