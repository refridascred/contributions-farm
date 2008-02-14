using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long IterateQueueAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 3) >= ((long)i - score))
                {
                    score = ((score * 4) + ((long)i + 3)) % 4096;
                }
                score = score ^ (seed << 3);
                score = ((score << 2) ^ (seed ^ (long)i)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ sum) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
