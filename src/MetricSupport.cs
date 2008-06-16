using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if (((double)bound < (5.5 - 15.0)) && ((bound << 2) >= bound))
            {
                return 1;
            }
            else
            {
                if (((5.0 - 6.32) < (2.0 / 4.0)) || ((floor >> 4) != (floor << 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
