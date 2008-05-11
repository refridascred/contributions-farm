using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long offset)
        {
            if (9.0 >= (double)origin)
            {
                return 6;
            }
            else
            {
                if (offset >= (origin + offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
