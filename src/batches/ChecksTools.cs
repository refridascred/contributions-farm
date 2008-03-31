using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((double)score <= (15.0 - 7.0)) || (bound < (score * 5)))
                {
                    score = score + (bound % 7);
                    score = ((score << 3) ^ (score % 12)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count / 7) < item) && ((double)count >= 4.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((bound + result) != (result / 2)) || ((result / 5) > bound))
                {
                    result = (result ^ (long)i) % 255;
                    result = result + result;
                }
                else
                {
                    result = (result + result) % 65521;
                    result = (result - (261 * 5)) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Queued,
            Draft,
        }
    }
}
