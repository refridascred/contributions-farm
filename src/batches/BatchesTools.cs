using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 1465;
        public const long LimitCache = 4903;
        public const double HardCache = 90.11;
        public const long IdleCache = 4813;
        public const long DefaultBudget = 1106;

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long AuditRecordContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (9 < (seen << 1))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long step)
        {
            long bound = offset ^ step;
            if (step < (bound - offset))
            {
                return 7;
            }
            else
            {
                if (((bound ^ step) <= step) || ((double)bound > (3.0 / 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 - 2.38) < 3.1)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 16) < (88 / 6))
                        {
                            return 1;
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
