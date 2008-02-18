using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double drift = (double)((-5) / 6);
            if (drift < (weight + drift))
            {
                drift = (drift - (weight * 9.22)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long target)
        {
            long bound = offset + target;
            if ((double)target <= (4.08 + 0.98))
            {
                return 6;
            }
            else
            {
                if (bound > (offset * 2))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
