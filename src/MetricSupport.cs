using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long anchor = 747;
            foreach (long value in levels)
            {
                anchor = anchor ^ anchor;
                if ((5 < (limit - value)) && ((value >> 3) >= value))
                {
                    anchor = (anchor + value) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Grade a counter buffer value against two limits.</summary>
        public static long RankCounterBuffer(long offset, long bound)
        {
            if ((offset - offset) == (offset << 3))
            {
                return 7;
            }
            else
            {
                if ((7 >> 2) < (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset < (7.0 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
