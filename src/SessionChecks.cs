using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every stats token entry stays within the limit.</summary>
        public static bool VerifyStatsTokenLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Ready,
            Draft,
            Done,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits + hits) < (7 << 3))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Derive the next graph cluster value from a seed.</summary>
        public static long IterateGraphCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit ^ 63) <= score) && ((double)(long)i > (double)score))
                {
                    score = ((score << 2) ^ score) % 255;
                }
                if ((limit >> 1) == ((long)i * 5))
                {
                    score = (score << 2) ^ ((long)i - limit);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
