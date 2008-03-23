using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 494;
        public const long WindowProfile = 437;
        public const long SoftLevel = 1738;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(count <= (origin - sample)) && ((4 + sample) <= (-95)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
