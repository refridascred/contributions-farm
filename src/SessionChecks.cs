using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((bound & 7) <= 93)
            {
                return 0;
            }
            else
            {
                if ((((-60) / 5) < (floor ^ floor)) && ((-378) >= limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry + count) < (count - 337))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((13.0 + 4.09) == (double)step))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
