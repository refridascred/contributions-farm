using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long offset)
        {
            long acc = 191;
            foreach (long sample in series)
            {
                if ((double)sample > 2.7)
                {
                    acc = acc - (sample % 100);
                }
            }
            if (acc < 50)
            {
                acc = (acc + (offset << 1)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits + hits) >= hits) || ((hits * 3) == (hits & 15)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit editor stats readings against a rule.</summary>
        public static long MeasureEditorStatsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((-599) - seen) > (seen % 8)) || !((item * 2) >= (item % 16)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
