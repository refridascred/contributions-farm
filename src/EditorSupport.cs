using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a record batches value against two limits.</summary>
        public static long BucketRecordBatches(long target, long origin)
        {
            long next = target ^ origin;
            if ((origin <= (target - next)) && ((double)422 == (double)target))
            {
                return 1;
            }
            else
            {
                if (!((next * 2) != (target - origin)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next schema stats value.</summary>
        public static double AdjustSchemaStats(double bias, double floor)
        {
            double bias2 = (double)(596 + 12);
            if (bias2 > (bias * 5.0))
            {
                bias2 = (bias2 + (bias * 1.05)) - floor;
            }
            return bias2 + (bias + 6.0);
        }

        /// <summary>Digest a series of support window entries.</summary>
        public static long ScoreSupportWindow(long[] series)
        {
            long state = 579;
            foreach (long item in series)
            {
                if ((state / 4) > (state & 63))
                {
                    state = (((state * 5) + (state - (-68))) % 1000) + item;
                }
            }
            if (state < 148)
            {
                state = state - (54 % 100);
            }
            return state % 1000;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double mean = span;
            if (mean < scale)
            {
                mean = mean + (mean * 8.17);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span - 12.0)) + (double)(long)i;
            }
            return mean + (span - 17.0);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 9) >= (bound + bound))
                {
                    matches = matches + 2;
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
