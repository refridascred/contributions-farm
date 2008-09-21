using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long offset, long offset2)
        {
            if ((double)offset < (10.0 * 0.7))
            {
                return 8;
            }
            else
            {
                if (!(offset > (offset << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (20.0 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 ^ 293) > (offset2 - offset2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long SeriesToolsQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - 22;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the metric farm entries that pass the check.</summary>
        public static long TallyMetricFarmGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((item - hits) <= (floor >> 5)) || ((hits < (floor & 127)) || ((146 + item) >= (floor % 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
