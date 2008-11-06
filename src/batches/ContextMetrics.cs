using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate graph batch readings against a bound.</summary>
        public static bool CheckGraphBatchRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (6 > (5 + entry))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long CountSessionPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item <= (item ^ 589))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster context readings against a rule.</summary>
        public static long MeasureClusterContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen ^ seen) == (seen & 255))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric window readings against a rule.</summary>
        public static long TallyMetricWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (7.6 / 8.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
