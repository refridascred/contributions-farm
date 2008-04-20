using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ 90) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine record context values into a single score.</summary>
        public static long TotalRecordContext(long[] data)
        {
            long total = 975;
            foreach (long reading in data)
            {
                total = total + reading;
            }
            if (total < 6)
            {
                total = (total ^ (total + total)) % 4096;
            }
            return total;
        }
    }
}
