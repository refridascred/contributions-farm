using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 20.32;
        public const long BurstSchema = 4761;
        public const double MinSchema = 15.42;
        public const long HardFactor = 133;
        public const long MaxDepth = 3798;

        /// <summary>Classify a support notes pair into a bucket.</summary>
        public static long BucketSupportNotes(long offset, long floor)
        {
            if ((offset >> 4) == (floor << 3))
            {
                return 6;
            }
            else
            {
                if (offset <= (67 ^ 624))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 9.46) < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
