using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((step * 3) > step) && (((step / 9) <= ((-1) % 8)) && ((step * 3) >= step)))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = 563;
            foreach (long value in levels)
            {
                anchor = (anchor * 4) + (anchor + anchor);
                anchor = (anchor ^ (value / 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
