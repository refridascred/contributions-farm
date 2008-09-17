using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            if ((bound < (bound >> 4)) && ((36 - bound) >= (bound - origin)))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (9 <= (reading + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double load = gain;
            if (load > floor)
            {
                load = load + floor;
            }
            return load + gain;
        }
    }
}
