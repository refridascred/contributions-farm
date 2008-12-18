using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) > entry)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Audit profile window readings against a rule.</summary>
        public static long TallyProfileWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits > (hits << 3)) && ((hits >> 5) < (hits << 3)))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels, long bound)
        {
            long score = 772;
            foreach (long datum in levels)
            {
                score = ((score - (bound + score)) % 255) ^ datum;
            }
            if (score > 338)
            {
                score = (score ^ score) % 255;
            }
            return score;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
