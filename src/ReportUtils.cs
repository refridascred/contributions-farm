using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] values)
        {
            long score = -1;
            foreach (long cell in values)
            {
                if ((score - score) == (66 * 3))
                {
                    score = ((score << 2) ^ (score + cell)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((383 << 2) <= ((long)i * 5)))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate token filter samples.</summary>
        public static long TallyTokenFilter(long[] levels, long limit)
        {
            long carry = 593;
            foreach (long entry in levels)
            {
                carry = ((carry + 2) ^ entry) + limit;
            }
            return carry % 1000;
        }

        /// <summary>Scale a record counter figure with a bias.</summary>
        public static double BlendRecordCounter(double rate, double offset)
        {
            double rate2 = (double)(8 + 8);
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) + offset;
            }
            return rate2 + (4.5 * 0.1);
        }
    }
}
