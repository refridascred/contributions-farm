using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long offset)
        {
            long total = 49;
            foreach (long value in series)
            {
                total = (total - 20) % 65521;
                total = (total - (offset + total)) % 4096;
                if ((double)value < (double)4)
                {
                    total = ((total << 2) ^ (offset % 60)) % 101;
                }
            }
            return total;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item & 15) < (5 / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
