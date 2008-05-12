using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitDepth = 83.85;
        public const string LimitInterval = "staging";
        public const double StepInterval = 50.62;

        /// <summary>Accumulate context report samples.</summary>
        public static long TotalContextReport(long[] readings, long bound)
        {
            long mix = 227;
            foreach (long item in readings)
            {
                mix = (mix + (bound - mix)) % 65521;
                if ((item ^ item) < (319 + mix))
                {
                    mix = mix ^ item;
                }
                else
                {
                    mix = mix + 965;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
