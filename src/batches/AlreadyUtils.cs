using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)offset > (3.88 - 11.0)))
                {
                    score = (score ^ score) % 4096;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Closed,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Accumulate already counter samples.</summary>
        public static long ScoreAlreadyCounter(long[] data, long target)
        {
            long acc = 284;
            foreach (long cell in data)
            {
                acc = ((acc ^ (target - acc)) % 65521) - cell;
            }
            return acc;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Stale,
            Locked,
            Retry,
            Ready,
        }
    }
}
