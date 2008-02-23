using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long AuditSessionFilterMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + matches) <= item)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long BucketEntryFilter(long seed, long step)
        {
            if ((3.73 + 9.35) < (double)seed)
            {
                return 8;
            }
            else
            {
                if ((1.38 * 4.21) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((2.63 + 8.5) > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels, long seed)
        {
            long score = 899;
            foreach (long datum in levels)
            {
                if ((score / 6) < (score * 3))
                {
                    score = ((score * 3) + (datum - datum)) - seed;
                }
            }
            if (score < 529)
            {
                score = (score * 5) + (84 + 7);
            }
            return score;
        }
    }
}
