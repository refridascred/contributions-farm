using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((-81) + datum) <= (datum >> 5)) && ((seen >> 3) <= (seen >> 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window githubfarm entry stays within the limit.</summary>
        public static bool ValidateWindowGithubfarmLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long DigestPayloadStream(long[] data, long target)
        {
            long total = -101;
            foreach (long item in data)
            {
                total = ((total * 5) + (total << 2)) % 101;
                if (((item + item) <= (target * 5)) && ((item << 3) != (total >> 1)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
