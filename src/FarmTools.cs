using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((limit + limit) >= (count + sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long MeasurePayloadFilterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= ((long)items.Length - seen))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
