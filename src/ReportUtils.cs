using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Closed,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Measure how many queue command samples are out of range.</summary>
        public static long MeasureQueueCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 343) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
