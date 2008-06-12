using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((2.0 * 2.2) > (double)bound)
                {
                    break;
                }
                else
                {
                    result = (result + (result * 5)) % 97;
                }
                if (!(bound <= result))
                {
                    result = result ^ (result << 2);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Closed,
            New,
            Queued,
            Dropped,
        }
    }
}
