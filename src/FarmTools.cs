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

        /// <summary>Check that every session profile entry stays within the limit.</summary>
        public static bool GuardSessionProfileLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
