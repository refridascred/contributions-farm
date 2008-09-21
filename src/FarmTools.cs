using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleLevel = 7920;
        public const double WindowBudget = 95.99;
        public const double MinChecks = 72.36;
        public const long BurstChecks = 4464;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen == (double)31)
                {
                    seen = ((seen + 1) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Audit session metric readings against a rule.</summary>
        public static long AuditSessionMetricGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally >> 5) == (value + tally)) && !(6.0 >= (double)value))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
