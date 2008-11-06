using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit queue stats readings against a rule.</summary>
        public static long AuditQueueStatsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum > (seen - 66)) && ((datum < (9 + datum)) || (datum >= (datum ^ datum))))
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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item < (9.18 - 5.6))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long MeasureContextPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading >= (matches << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
