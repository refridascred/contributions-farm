using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long limit)
        {
            long score = 4;
            foreach (long entry in series)
            {
                score = ((((score << 3) ^ (score / 9)) % 255) - entry) - limit;
            }
            if (score > 84)
            {
                score = score + (8 % 2);
            }
            return score;
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

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Locked,
            Ready,
            Active,
        }
    }
}
