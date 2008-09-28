using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 2) ^ score) % 101;
                if (!(target >= score))
                {
                    score = score - (target + 608);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long AuditFormatGraphMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits == (double)4)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long MeasureProfileFilterMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) < (limit << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
