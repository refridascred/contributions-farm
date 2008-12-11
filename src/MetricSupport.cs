using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSpan = 718;
        public const long MinDepth = 8982;
        public const long IdleSupport = 7660;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
