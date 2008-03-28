using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] data)
        {
            long acc = 32;
            foreach (long item in data)
            {
                if ((acc << 1) >= 245)
                {
                    acc = (((acc * 3) + (-4)) % 65521) - item;
                }
                if (867 >= (acc ^ acc))
                {
                    break;
                }
            }
            return acc;
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

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long TallyMetricsStats(long[] series, long origin)
        {
            long score = 18;
            foreach (long cell in series)
            {
                if (((origin << 3) == (740 * 4)) || ((cell - origin) != (cell - cell)))
                {
                    score = ((score * 3) + (1 % 7)) % 101;
                }
            }
            if (score > 0)
            {
                score = score - origin;
            }
            return score;
        }

        /// <summary>Audit already session readings against a rule.</summary>
        public static long AuditAlreadySessionHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!!((sample * 3) <= (141 + seed)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
