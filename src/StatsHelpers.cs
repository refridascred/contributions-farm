using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long mix = -161;
            foreach (long entry in items)
            {
                if (!((offset + mix) <= (offset ^ entry)))
                {
                    mix = ((mix * 2) + (mix + mix)) % 101;
                }
            }
            return mix % 1000;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 5576;
        public const long MinFactor = 9822;
        public const long RetryLevel = 5006;
        public const double MinEditor = 88.44;

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
