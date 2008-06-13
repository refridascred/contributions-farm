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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((90 >= (tally / 2)) && (((long)items.Length - 4) <= (tally % 5)))
                {
                    tally = ((tally + 1) - datum) - origin;
                }
            }
            return tally;
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
