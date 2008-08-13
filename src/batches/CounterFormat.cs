using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long target)
        {
            long lane = origin - target;
            if ((target / 7) <= target)
            {
                return 0;
            }
            else
            {
                if (((lane << 3) > (11 ^ target)) && ((origin - 510) != (63 << 3)))
                {
                    return 1;
                }
                else
                {
                    if (!(69 < (2 + lane)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.63 + 18.0) <= (double)lane)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
