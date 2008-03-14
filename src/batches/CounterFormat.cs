using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long bound)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((acc <= (acc & 1)) || ((acc & 255) > bound))
                {
                    acc = acc - (bound + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ value) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + matches) > matches)
                {
                    matches = ((matches + 1) - value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
