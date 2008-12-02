using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + ((long)i + 2)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowDepth = 686;
        public const double LimitChannel = 25.33;
        public const long IdleLevel = 3940;
        public const long IdleBudget = 2249;
    }
}
