using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit session token readings against a rule.</summary>
        public static long CountSessionTokenOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((floor & 7) == (matches + matches)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report counter samples.</summary>
        public static long TotalReportCounter(long[] items)
        {
            long score = 307;
            foreach (long value in items)
            {
                score = ((score * 4) + (score ^ (-5))) ^ value;
            }
            return score;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((592 ^ seen) > cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a token context reading by value.</summary>
        public static long LookupTokenContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
