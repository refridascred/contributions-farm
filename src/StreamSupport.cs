using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long score = 52;
            foreach (long entry in values)
            {
                if ((double)offset < (6.5 / 2.0))
                {
                    score = ((score << 3) ^ score) ^ entry;
                }
            }
            return score;
        }

        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long target, long origin)
        {
            long lane = target + origin;
            if (lane <= (18 + origin))
            {
                return 5;
            }
            else
            {
                if ((lane % 12) < (origin / 6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
