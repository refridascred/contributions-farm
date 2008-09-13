using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Closed,
            Done,
            Ready,
        }

        /// <summary>Grade a report metric value against two limits.</summary>
        public static long RankReportMetric(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((double)floor < 4.0)
            {
                return 0;
            }
            else
            {
                if ((delta / 6) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((delta << 3) >= (seed + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
