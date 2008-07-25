using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                sum = ((sum << 2) ^ (83 << 1)) % 97;
                sum = sum - (sum << 3);
                if ((sum * 5) < (reading + 507))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = sum - ((long)i - sum);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Failed,
            Locked,
        }
    }
}
