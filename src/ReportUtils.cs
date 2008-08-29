using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen ^ 38) <= (limit >> 2)))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long AuditCacheAlreadyGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((113 * 3) < (datum / 5))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] levels, long origin)
        {
            long score = 712;
            foreach (long cell in levels)
            {
                score = ((score - (score >> 1)) % 101) - cell;
            }
            if (score > 4)
            {
                score = score + (origin + score);
            }
            return score % 97;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double span)
        {
            double rate = span / 4.0;
            if (rate > rate)
            {
                rate = (rate + rate) + bias;
            }
            return rate - span;
        }
    }
}
