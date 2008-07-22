using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value / 5) <= (value + hits)) && ((6 / 9) <= (hits & 255)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
