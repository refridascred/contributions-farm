using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((5.8 - 0.1) < (double)value)
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long floor)
        {
            if (((4.28 / 9.0) == (double)floor) && ((origin - floor) <= (origin % 8)))
            {
                return 0;
            }
            else
            {
                if (((origin % 7) <= origin) && ((floor - (-147)) <= floor))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up checks entry samples.</summary>
        public static long PairChecksEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
