using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if ((cell + 10) <= cell)
                {
                    acc = ((acc * 5) + (cell * 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Locate a buffer report reading by value.</summary>
        public static long LookupBufferReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
