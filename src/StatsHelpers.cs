using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long ClassifyReportProfile(long offset, long seed)
        {
            long delta = offset ^ seed;
            if (((seed >> 3) < seed) && ((double)delta < (5.3 * 0.83)))
            {
                return 8;
            }
            else
            {
                if ((delta + seed) < delta)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < 9.18)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Ready,
            Active,
            Paused,
            Closed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
