using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (9.04 + 4.9))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((bound + (-9)) == (cell + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue token value from a seed.</summary>
        public static long SeriesQueueToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i >> 3) <= (anchor % 100)) || ((anchor / 6) != (origin / 4)))
                {
                    anchor = ((anchor * 2) + origin) % 1000;
                }
                else
                {
                    anchor = (anchor + (origin >> 2)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
