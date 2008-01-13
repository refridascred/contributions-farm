using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry >= target) || !(entry < (entry + target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step % 10) >= sum)
                {
                    sum = ((sum << 3) ^ sum) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
