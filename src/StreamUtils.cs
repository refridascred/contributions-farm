using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length <= cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long result = 226;
            foreach (long value in items)
            {
                result = (result - (46 / 3)) ^ value;
            }
            if (result < 7)
            {
                result = (result << 2) ^ (result >> 1);
            }
            return result % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (double)0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches % 24) >= (20 * 2))
                {
                    matches = ((matches + 1) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Queued,
            Done,
            Draft,
            Locked,
        }
    }
}
