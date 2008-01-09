using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSize = 18.05;
        public const string MinSupport = "local-v2";
        public const double DefaultSupport = 20.35;

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long limit)
        {
            if ((double)limit == (6.3 - 15.0))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) > offset)
                {
                    return 0;
                }
                else
                {
                    if (((offset + offset) != (limit >> 1)) || ((limit + offset) <= (1 + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
