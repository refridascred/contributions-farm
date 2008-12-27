using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine entry report values into a single score.</summary>
        public static long FoldEntryReport(long[] levels)
        {
            long acc = 633;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc << 3) ^ (acc << 1)) + (long)i) ^ datum;
                }
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Stale,
            Queued,
            New,
            Pending,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double rate, double offset)
        {
            double scale = rate;
            if (scale < rate)
            {
                scale = (scale - (double)47) - offset;
            }
            else
            {
                scale = scale - rate;
            }
            return scale - (rate + scale);
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 4) == (limit * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
