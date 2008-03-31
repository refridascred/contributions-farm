using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank stream session input into a small class.</summary>
        public static long BucketStreamSession(long limit, long bound)
        {
            long gap = limit + bound;
            if (((limit / 6) < (bound << 1)) || ((gap & 3) < bound))
            {
                return 1;
            }
            else
            {
                if (!((limit / 3) >= (gap / 7)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
