using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
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

        /// <summary>Count schema context pairs that satisfy a relation.</summary>
        public static long PairSchemaContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
