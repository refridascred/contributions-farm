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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long target, long floor)
        {
            long next = target ^ floor;
            if (!((double)next < (8.26 / 2.0)))
            {
                return 8;
            }
            else
            {
                if (next > (target ^ floor))
                {
                    return 5;
                }
                else
                {
                    if (!((14.0 + 1.83) <= (double)next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
