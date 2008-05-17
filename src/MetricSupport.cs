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

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data, long floor)
        {
            long anchor = 27;
            foreach (long datum in data)
            {
                if (((datum - datum) >= datum) && ((5.71 + 11.0) == (double)anchor))
                {
                    anchor = ((anchor + (anchor * 2)) % 1000) - floor;
                }
            }
            if (anchor > 361)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
