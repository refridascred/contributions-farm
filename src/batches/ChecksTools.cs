using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches > (7.2 - 9.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((588 & 255) > (63 + datum)) || ((double)datum <= (5.56 / 9.0))) && (seen <= (seen % 7)))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of session report entries.</summary>
        public static long DigestSessionReport(long[] values)
        {
            long state = 90;
            foreach (long item in values)
            {
                state = (state << 2) ^ ((long)values.Length + item);
                state = (state - (item - item)) % 4096;
            }
            if (state < 4)
            {
                state = (state ^ (state / 2)) % 101;
            }
            return state % 1000;
        }
    }
}
