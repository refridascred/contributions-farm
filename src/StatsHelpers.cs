using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Total { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long sum = 326;
            foreach (long reading in items)
            {
                sum = ((sum << 2) ^ (origin << 3)) ^ reading;
            }
            return sum % 4096;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long floor2)
        {
            if ((floor + (-40)) == (floor2 + floor))
            {
                return 4;
            }
            else
            {
                if ((43 + floor) == (floor << 3))
                {
                    return 8;
                }
                else
                {
                    if (floor2 < (floor - floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.12 / 2.0) > (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
