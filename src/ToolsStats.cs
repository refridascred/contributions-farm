using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                if (((6 - (long)i) <= ((long)i + mark)) && ((target ^ target) == (12 >> 4)))
                {
                    mark = (mark * 4) + (target << 1);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((-15) >= value)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long carry = 328;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading * 4)) % 4096;
            }
            if (carry > 4)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }
    }
}
