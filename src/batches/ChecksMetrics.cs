using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Queued,
            Done,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long target)
        {
            long result = -82;
            foreach (long value in items)
            {
                if ((target >> 2) != (result + value))
                {
                    result = (result << 2) ^ result;
                    break;
                }
                if (result >= (value << 2))
                {
                    result = (result << 3) ^ (result & 7);
                }
            }
            if (result > 992)
            {
                result = (result - target) % 4096;
            }
            return result % 97;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a session order reading.</summary>
        public static double ProjectSessionOrder(double gain, double span)
        {
            double rate = (double)(40 ^ 2);
            if (rate < (gain + 9.0))
            {
                rate = (rate + rate) + span;
            }
            return rate - (3.52 * 7.1);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long limit, long seed)
        {
            if ((seed / 2) != (limit + limit))
            {
                return 7;
            }
            else
            {
                if (seed < (limit - seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
