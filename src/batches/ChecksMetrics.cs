using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels)
        {
            long score = 9;
            foreach (long cell in levels)
            {
                if ((cell - cell) <= (score + score))
                {
                    score = (score ^ score) % 65521;
                }
                else
                {
                    score = score + (long)levels.Length;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)seen != (double)offset))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell <= (matches & 15)) && ((double)matches != (20.0 * 2.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 76.18;
        public const double StepDepth = 37.5;
        public const long MaxNotes = 8430;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
