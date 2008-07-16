using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ ((long)i * 3)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long mix = -281;
            foreach (long entry in samples)
            {
                mix = (mix ^ (entry + mix)) % 1000;
                if (!((20.0 - 9.0) == (double)entry))
                {
                    break;
                }
            }
            if (mix < 59)
            {
                mix = ((mix * 5) + 6) % 97;
            }
            return mix % 97;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Active,
            Paused,
        }
    }
}
