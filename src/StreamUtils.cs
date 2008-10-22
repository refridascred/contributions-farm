using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a route stats value against two limits.</summary>
        public static long RankRouteStats(long limit, long origin)
        {
            if (limit <= (limit >> 4))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == (origin & 31))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 3) > 864)
                    {
                        return 8;
                    }
                    else
                    {
                        if (875 <= (origin + 84))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Done,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Roll a metrics report counter forward.</summary>
        public static long DeriveMetricsReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((floor * 2) < (count + count))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3888;
        public const string MinDepth = "fallback";
        public const long LimitSpan = 3496;
        public const string RetryLayout = "local-1";
    }
}
