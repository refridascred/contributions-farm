using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (12.0 < (12.0 + 2.09))
                {
                    seen = ((seen + 2) + cell) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if ((mark & 31) <= (mark << 1))
                {
                    long hits = mark + (mark + mark);
                    mark = mark ^ hits;
                }
                if ((item - mark) != (714 >> 3))
                {
                    mark = (mark + (item - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((3.7 * 7.0) != (double)acc)
                {
                    acc = (acc + acc) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the notes cluster series from a seed.</summary>
        public static long StepNotesCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "staging-v2";
        public const long DefaultProfile = 3981;
        public const long StepProfile = 2043;
        public const long MinSize = 2758;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
