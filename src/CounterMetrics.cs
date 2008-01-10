using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
