using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long WeighStatsSession(long[] levels)
        {
            long mix = 36;
            foreach (long reading in levels)
            {
                if ((1.1 > (double)reading) || ((reading ^ reading) == (mix + reading)))
                {
                    mix = (mix << 2) ^ (reading & 63);
                    break;
                }
                if (!(reading > mix))
                {
                    mix = (mix * 5) + (mix * 2);
                }
                else
                {
                    mix = (mix << 2) ^ 55;
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (mix & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSize = 7517;
        public const string DefaultTools = "stable-1";
        public const long IdleBudget = 414;

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long RollCounterStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public bool Score { get; set; }
        }
    }
}
