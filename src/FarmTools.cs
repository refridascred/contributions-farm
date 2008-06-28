using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7075;
        public const string StepCount = "fallback";
        public const long LimitLevel = 655;
        public const string WindowScore = "standard-v2";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
