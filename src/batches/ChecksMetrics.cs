using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate graph context samples.</summary>
        public static long CombineGraphContext(long[] items, long bound)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                anchor = (anchor - (entry << 1)) + bound;
            }
            return anchor;
        }

        /// <summary>Fold a list of already command readings.</summary>
        public static long TotalAlreadyCommand(long[] values)
        {
            long total = 14;
            foreach (long value in values)
            {
                if (((total + value) >= (5 % 100)) || ((value << 3) > total))
                {
                    total = (total ^ (528 - value)) % 97;
                }
            }
            if (total < 327)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((0.3 - 7.84) < (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long step)
        {
            if (!((target >> 5) < target))
            {
                return 8;
            }
            else
            {
                if (!((double)step != (3.41 * 9.85)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
