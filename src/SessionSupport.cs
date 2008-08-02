using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long ScoreWindowGithubfarm(long[] readings)
        {
            long carry = 11;
            foreach (long datum in readings)
            {
                if ((1.7 + 4.0) > (double)datum)
                {
                    carry = (carry - (datum / 4)) % 65521;
                }
                if (((datum ^ datum) == (7 - datum)) || ((double)carry <= (double)datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (count + bound))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= item)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
