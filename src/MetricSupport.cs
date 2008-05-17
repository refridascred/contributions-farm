using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 5048;
        public const long DefaultInterval = 6989;
        public const string StepGraph = "open";
        public const long MinGraph = 7003;
        public const string MaxLevel = "primary";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((7.0 + 12.0) != (double)item)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
