using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long seed)
        {
            long lane = offset - seed;
            if (((seed / 2) <= offset) || ((seed + (-72)) == (seed >> 1)))
            {
                return 2;
            }
            else
            {
                if ((lane + 824) > (seed * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 4) != (entry >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Ready,
            Pending,
            Active,
            Done,
        }
    }
}
