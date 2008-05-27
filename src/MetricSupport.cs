using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long AuditBatchContextHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading < (count >> 4)) && (((889 / 7) > (618 ^ count)) || ((count >> 1) == (822 + count))))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
