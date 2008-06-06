using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up filter buffer samples.</summary>
        public static long PairFilterBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((step ^ item) < (step + item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long origin2)
        {
            if ((3.0 + 1.6) == (double)origin2)
            {
                return 8;
            }
            else
            {
                if ((origin << 1) == (origin2 & 15))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) < ((-93) >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
