using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if (((target << 3) != (total >> 5)) && ((double)total >= 8.99))
                {
                    total = (total ^ (94 + target)) % 1000;
                }
                total = (total * 5) + (total + total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
