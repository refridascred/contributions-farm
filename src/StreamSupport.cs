using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long step)
        {
            long slot = seed ^ step;
            if (seed <= (177 + step))
            {
                return 6;
            }
            else
            {
                if ((seed + slot) > (3 + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
