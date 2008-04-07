using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Queued,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long target2)
        {
            long cur = target ^ target2;
            if ((944 + target) > (cur << 1))
            {
                return 5;
            }
            else
            {
                if ((cur << 1) > target2)
                {
                    return 3;
                }
                else
                {
                    if (!((61 - target2) <= (cur * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8 > (target / 5)) && ((target2 / 7) > (706 - target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
