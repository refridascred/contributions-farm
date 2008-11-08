using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            long offset = step ^ seed;
            if ((seed - offset) <= 639)
            {
                return 6;
            }
            else
            {
                if ((6 - seed) <= (offset ^ seed))
                {
                    return 4;
                }
                else
                {
                    if (step < (step + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((double)step != (7.0 - 0.8)))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((score << 1) != (30 & 255))
                {
                    score = score + limit;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long target, long step)
        {
            long bound = target - step;
            if ((target * 4) == (1 & 3))
            {
                return 5;
            }
            else
            {
                if ((target < bound) || ((9.86 * 8.03) >= (double)target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
