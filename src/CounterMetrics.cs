using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long PairChecksContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long MeasureCacheMetricsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (4 - 91))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 82) != (item - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
