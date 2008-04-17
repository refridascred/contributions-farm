using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long offset)
        {
            if ((double)limit == (double)offset)
            {
                return 7;
            }
            else
            {
                if (((offset / 9) == (offset + offset)) || ((limit + 27) >= (525 >> 2)))
                {
                    return 8;
                }
                else
                {
                    if (offset >= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit <= 1.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix + bound)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mark = -7;
            foreach (long sample in levels)
            {
                mark = ((mark * 2) + (sample / 2)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
