using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (acc - seed)) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length << 1) <= (6 + limit))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long MeasureGraphRouteMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) > (origin * 2)) && ((seen >= (seen * 5)) || ((97 + 917) != (origin ^ origin))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
