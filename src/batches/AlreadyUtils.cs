using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ acc) % 1000;
                acc = (acc * 3) + (limit / 3);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] series)
        {
            long anchor = 651;
            foreach (long cell in series)
            {
                if ((double)cell >= (0.45 - 8.7))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (cell + anchor)) % 4096;
                }
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Ready,
            Done,
        }
    }
}
