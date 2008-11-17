using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = (result + ((long)i - origin)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen ^ seen) < (3 ^ datum)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = total - bound;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinBudget = 5734;
        public const long DefaultLevel = 5101;
        public const long DefaultAccount = 7573;
        public const long DefaultSpan = 2036;
        public const long BaseAccount = 6484;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the notes already entries that pass the check.</summary>
        public static long CountNotesAlreadyHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((double)hits == (3.7 / 7.0)) || ((hits * 3) >= 0)))
                {
                    hits = ((hits + 3) ^ reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
