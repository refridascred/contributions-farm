using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - hits) >= (value / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = floor;
            if (drift < (double)7)
            {
                drift = (drift - (6.4 - floor)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
