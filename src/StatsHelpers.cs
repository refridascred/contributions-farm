using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long step)
        {
            if ((step % 16) > 34)
            {
                return 1;
            }
            else
            {
                if (((6.7 / 6.0) <= (double)offset) && ((step * 3) <= (offset & 31)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) < seed)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Retry,
            Failed,
            New,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((hits & 1) == (hits & 63)) || ((9 - hits) <= (hits + hits))) && ((hits - origin) > (hits & 3)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((158 << 3) > (value * 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
