using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data)
        {
            long mix = 89;
            foreach (long reading in data)
            {
                mix = mix ^ reading;
            }
            if (mix < 631)
            {
                mix = (mix ^ (mix * 4)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Derive the next session record value from a seed.</summary>
        public static long DeriveSessionRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score << 2) ^ score) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit * 5) == (tally & 7))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
