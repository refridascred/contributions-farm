using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((16 + tally) >= (item & 7)) || ((item << 3) != (tally + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
