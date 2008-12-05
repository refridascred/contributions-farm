using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + cell) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i << 1) >= ((long)i - (-78)))
                {
                    total = (total - (-5)) % 1000;
                }
                total = (total ^ ((long)i >> 1)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a report graph counter forward.</summary>
        public static long RollReportGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if (32 < (acc & 7))
                {
                    acc = ((acc << 2) ^ (bound - acc)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            New,
            Idle,
        }
    }
}
