using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count >> 5) > (offset << 1))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long origin)
        {
            long prev = target + origin;
            if ((1.0 <= (double)prev) || ((2.35 + 6.0) <= (double)prev))
            {
                return 6;
            }
            else
            {
                if ((87 << 1) >= (origin ^ prev))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm notes counter forward.</summary>
        public static long IterateGithubfarmNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound + 0) <= (544 & 255))
                {
                    state = ((state * 5) + bound) % 65521;
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
