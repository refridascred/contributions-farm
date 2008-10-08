using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "open-v2";
        public const double BatchBudget = 42.97;
        public const long HardLayout = 4037;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
