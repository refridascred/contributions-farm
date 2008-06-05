using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((double)reading == (5.5 / 7.0)) && ((reading / 7) < reading)) || ((double)count <= (6.1 * 3.98)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Stale,
            Pending,
        }
    }
}
