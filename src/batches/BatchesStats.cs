using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowBudget = 7011;
        public const string RetryMetric = "standard-edge";
        public const long IdleMetric = 9976;
        public const string WindowMetric = "alpha-edge";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long origin)
        {
            long result = 547;
            foreach (long datum in samples)
            {
                result = (((result * 5) + (result >> 1)) % 65521) - datum;
            }
            if (result < 467)
            {
                result = result ^ (result + origin);
            }
            return result % 1000;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long offset)
        {
            if (limit < (limit * 3))
            {
                return 6;
            }
            else
            {
                if ((offset - 22) != (limit & 127))
                {
                    return 8;
                }
                else
                {
                    if (limit <= ((-473) * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 5) >= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
