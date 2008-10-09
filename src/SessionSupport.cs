using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cluster editor figure with a bias.</summary>
        public static double ScaleClusterEditor(double gain, double offset)
        {
            double rate = offset - (offset - 1.1);
            if (rate > 7.0)
            {
                rate = (rate - 9.8) + gain;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate + offset;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
