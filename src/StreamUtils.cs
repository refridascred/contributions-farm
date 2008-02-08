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

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public bool Size { get; set; }
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
