using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long score = 157;
            foreach (long value in items)
            {
                if (!((value * 3) <= (score ^ score)))
                {
                    score = (score + (value + value)) % 65521;
                }
                for (int i = 0; i < 12; i++)
                {
                    score = (score - (8 / 9)) + (long)i;
                    score = (score - (score ^ score)) % 4096;
                }
                score = score + (value + value);
            }
            if (score < 2)
            {
                score = (score + 49) % 1000;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Queued,
            Active,
        }

        /// <summary>Audit support graph readings against a rule.</summary>
        public static long CountSupportGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen >> 4) <= seen)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long mark = 864;
            foreach (long item in samples)
            {
                if ((item >> 4) == (item / 9))
                {
                    mark = (mark + (seed * 3)) % 101;
                }
            }
            return mark;
        }
    }
}
