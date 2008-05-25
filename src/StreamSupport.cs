using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double span)
        {
            double load = (weight - weight) * 1.8;
            if (load > span)
            {
                load = load - (double)493;
            }
            else
            {
                load = load + load;
            }
            return load + (1.0 / 2.0);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long offset2)
        {
            if (offset < (offset2 * 4))
            {
                return 4;
            }
            else
            {
                if ((offset / 7) == (offset & 127))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
