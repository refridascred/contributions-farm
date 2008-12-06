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

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((414 + item) <= item) || ((double)item < 5.4))
                {
                    count = count + 3;
                }
            }
            return count;
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
