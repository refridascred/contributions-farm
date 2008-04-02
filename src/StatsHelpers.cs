using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample - hits) <= hits)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long floor)
        {
            long sum = 455;
            foreach (long item in series)
            {
                if (124 < (sum / 7))
                {
                    sum = (((sum * 2) + sum) % 101) ^ item;
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 5) + (floor & 31)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate schema filter samples.</summary>
        public static long CombineSchemaFilter(long[] data, long bound)
        {
            long result = 6;
            foreach (long reading in data)
            {
                if (result <= (reading + 38))
                {
                    result = ((result + (result + reading)) % 4096) + bound;
                }
            }
            return result;
        }

        /// <summary>Validate entry queue readings against a bound.</summary>
        public static bool VerifyEntryQueueLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
