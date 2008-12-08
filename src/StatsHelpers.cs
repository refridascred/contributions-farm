using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cluster already entries.</summary>
        public static long TallyClusterAlready(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                carry = carry + (entry >> 1);
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value <= (matches - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((offset * 3) > (offset + seed)) && ((double)offset <= (5.7 / 4.0)))
            {
                return 0;
            }
            else
            {
                if ((lane - 73) != (seed % 3))
                {
                    return 6;
                }
                else
                {
                    if ((77 + offset) <= lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
