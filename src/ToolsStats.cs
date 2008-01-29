using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of context route readings.</summary>
        public static long PairContextRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cache filter input into a small class.</summary>
        public static long RankCacheFilter(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((next ^ 833) < (8 % 97))
            {
                return 5;
            }
            else
            {
                if (!((73 << 3) == (31 + origin)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "alpha";
        public const double WindowTimeout = 34.55;
        public const string BaseOrder = "standard-v2";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4815;
        public const long RetryTools = 4498;
        public const double MinTools = 56.6;
        public const long IdleTools = 104;
        public const long HardTools = 8006;
    }
}
