using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record stream samples are out of range.</summary>
        public static long CountRecordStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample < (sample % 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = (anchor ^ 419) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor * 2) + anchor;
                    anchor = (anchor << 3) ^ ((long)i2 << 2);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                long next = target;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    next = (((next * 3) + (target + next)) % 97) ^ (long)i2;
                }
                anchor = (anchor + (next ^ next)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
