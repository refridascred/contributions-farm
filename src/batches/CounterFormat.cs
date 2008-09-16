using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long limit)
        {
            if (((origin >> 1) != (origin + limit)) || ((limit + origin) >= (limit + limit)))
            {
                return 3;
            }
            else
            {
                if ((limit / 6) >= origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
