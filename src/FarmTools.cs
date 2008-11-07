using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine context already values into a single score.</summary>
        public static long CombineContextAlready(long[] values, long target)
        {
            long score = 6;
            foreach (long item in values)
            {
                score = (score + (target / 7)) ^ item;
            }
            return score;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long AuditBatchesOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) > reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics contributi readings against a bound.</summary>
        public static bool ValidateMetricsContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
