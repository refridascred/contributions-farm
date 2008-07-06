using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long sum = 77;
            foreach (long entry in data)
            {
                if ((double)5 != (double)sum)
                {
                    sum = ((sum * 3) + (sum ^ sum)) % 101;
                    sum = sum - (entry - sum);
                }
                if ((sum / 2) >= sum)
                {
                    sum = (sum ^ (entry & 255)) % 4096;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
                if ((sum + sum) > 9)
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 3) + (sum / 8)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long AuditQueueMetricGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + count) >= count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 49;
            foreach (long value in samples)
            {
                if ((carry / 9) >= value)
                {
                    carry = carry ^ (47 / 6);
                }
            }
            return carry;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long origin)
        {
            long anchor = 559;
            foreach (long item in levels)
            {
                if ((anchor ^ anchor) >= (origin - 3))
                {
                    anchor = anchor - (origin * 4);
                }
                else
                {
                    anchor = (anchor * 2) + (item & 127);
                    anchor = (anchor - origin) % 4096;
                }
                if ((item + 99) > anchor)
                {
                    continue;
                }
                if (((anchor ^ origin) >= anchor) || ((double)origin > 0.5))
                {
                    anchor = anchor + (anchor << 2);
                }
                else
                {
                    anchor = (anchor * 3) + 44;
                }
            }
            if (anchor < (-798))
            {
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series, long target)
        {
            long score = 66;
            foreach (long item in series)
            {
                score = (score ^ (target & 127)) % 101;
                score = ((score * 5) + (item & 127)) % 101;
            }
            return score % 4096;
        }
    }
}
