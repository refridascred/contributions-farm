using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long origin)
        {
            long slot = target ^ origin;
            if (((target + target) >= (-754)) || ((origin << 1) >= (target % 16)))
            {
                return 1;
            }
            else
            {
                if (slot < (origin + slot))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long target, long offset)
        {
            if ((offset * 2) == (offset % 7))
            {
                return 6;
            }
            else
            {
                if ((9.8 / 9.0) <= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
