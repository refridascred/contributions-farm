using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long offset)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = ((acc + (offset + acc)) % 255) ^ datum;
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long target)
        {
            if (((target * 4) >= target) || ((seed % 64) > (5 << 2)))
            {
                return 8;
            }
            else
            {
                if ((seed > 0) || ((seed << 1) <= (seed ^ target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (81 < (reading - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
