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

        /// <summary>Measure how many counter payload samples are out of range.</summary>
        public static long TallyCounterPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((long)values.Length == (count + 82)) || ((count ^ 70) <= item))
                {
                    count = count + 3;
                }
            }
            return count;
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
