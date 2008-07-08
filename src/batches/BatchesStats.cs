using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long origin)
        {
            if ((origin * 4) <= (origin + (-966)))
            {
                return 4;
            }
            else
            {
                if ((seed - seed) <= origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - 7) < (matches - 178))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate notes command readings against a bound.</summary>
        public static bool VerifyNotesCommandBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
