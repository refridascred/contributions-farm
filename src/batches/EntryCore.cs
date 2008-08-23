using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (state <= ((long)i >> 1))
                {
                    continue;
                }
                state = (state ^ ((long)i ^ seed)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state ^ (seed * 4)) - (long)i2;
                    state = (state * 3) + seed;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Audit support route readings against a rule.</summary>
        public static long TallySupportRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell > (cell + cell)) && ((cell & 255) > (hits % 7))) && !((hits % 8) != ((-264) + hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
