using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long origin, long bound)
        {
            long span = origin + bound;
            if ((5.0 < (double)bound) && ((span + span) == (span * 4)))
            {
                return 8;
            }
            else
            {
                if ((bound / 4) != (bound & 127))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 3) >= (span + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
