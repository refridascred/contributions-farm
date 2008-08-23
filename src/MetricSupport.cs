using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxRatio = "cached-v2";
        public const long StepChannel = 5835;
        public const string SoftChannel = "open-edge";

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long step)
        {
            long bound = offset + step;
            if ((double)offset < 2.2)
            {
                return 5;
            }
            else
            {
                if ((step % 2) == (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
