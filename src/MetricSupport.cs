using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            New,
            Synced,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if (!((target - target) < (75 + 8)))
            {
                return 3;
            }
            else
            {
                if (!((double)target <= (double)51))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) < (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)921 > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
