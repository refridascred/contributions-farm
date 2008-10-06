using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((floor - datum) != (2 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the account editor entries that pass the check.</summary>
        public static long AuditAccountEditorMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches % 5) <= cell) || ((cell + cell) >= (long)samples.Length)) && ((cell ^ matches) >= ((long)samples.Length / 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((92 >> 5) <= origin)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry + (bound / 2)) % 101) - (long)i2;
                    carry = ((carry * 2) + bound) % 65521;
                }
                carry = (carry + bound) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
