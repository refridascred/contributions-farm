using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit queue commits readings against a rule.</summary>
        public static long AuditQueueCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - tally) == ((-76) ^ (long)samples.Length))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Retry,
            Failed,
            Synced,
            Active,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = (scale - (double)550) - bias;
            }
            return scale + span;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (!((origin2 & 31) <= delta))
            {
                return 2;
            }
            else
            {
                if ((origin2 * 4) == (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if ((delta + origin2) == (origin + delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin & 3) <= (delta + 76))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
