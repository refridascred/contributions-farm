using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Synced,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer record samples are out of range.</summary>
        public static long TallyBufferRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally << 1) < (tally >> 4))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Count farm command pairs that satisfy a relation.</summary>
        public static long CompareFarmCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double bias = scale;
            return (bias + (9.06 * 11.0)) + offset;
        }

        /// <summary>Derive the next graph command value from a seed.</summary>
        public static long IterateGraphCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i < (17.0 - 5.0))
                {
                    mark = ((mark << 2) ^ (floor ^ 4)) % 97;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
