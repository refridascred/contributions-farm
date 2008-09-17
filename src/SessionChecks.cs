using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of metrics layout entries.</summary>
        public static long DigestMetricsLayout(long[] items, long bound)
        {
            long total = 907;
            foreach (long item in items)
            {
                total = ((total - total) % 1000) + item;
                if (total > bound)
                {
                    total = (total + total) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading < (reading + matches)) && ((double)reading != (7.4 * 12.0))) || ((double)reading == (6.1 / 5.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
