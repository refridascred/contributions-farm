using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout graph readings against a rule.</summary>
        public static long CountLayoutGraphHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - tally) == (tally + tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((1 * 5) <= (sample & 3)) || ((double)sample < (double)2))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long TallyPayloadWindowMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 5) < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
