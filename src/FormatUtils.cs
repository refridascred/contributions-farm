using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record report counter forward.</summary>
        public static long RollRecordReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state - ((long)i + origin)) % 255;
                state = state ^ (615 ^ state);
                if (!((double)state >= (double)state))
                {
                    state = state - ((long)i + origin);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
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
