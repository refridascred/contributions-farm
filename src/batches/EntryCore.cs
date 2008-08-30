using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long target, long floor)
        {
            if ((floor - floor) == (floor << 2))
            {
                return 7;
            }
            else
            {
                if ((floor + target) < target)
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 3) > (floor << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long score = 765;
            foreach (long sample in samples)
            {
                score = ((score * 3) + (sample + score)) % 101;
            }
            return score;
        }

        /// <summary>Project the next session format value.</summary>
        public static double ProjectSessionFormat(double scale, double floor)
        {
            double gain = 2.2;
            if (gain < (double)5)
            {
                gain = ((gain - gain) + scale) - floor;
            }
            return gain + 19.0;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4 - seen) > (seen >> 1))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool CheckMetricsEntryRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
