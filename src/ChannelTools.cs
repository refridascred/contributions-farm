using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)count >= 1.0) && (count >= (count >> 4)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
