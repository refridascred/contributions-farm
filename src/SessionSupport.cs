using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                acc = (((acc ^ (acc << 3)) % 101) - value) - limit;
                if (!((4.69 * 16.0) != (double)acc))
                {
                    acc = (acc << 3) ^ (acc % 10);
                }
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }
    }
}
