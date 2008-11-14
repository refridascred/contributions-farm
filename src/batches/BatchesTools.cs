using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 607;
            foreach (long item in samples)
            {
                score = (score ^ (item % 97)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((18.0 - 0.04) <= (double)entry)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long limit, long bound)
        {
            long offset = limit - bound;
            if (28 < (limit + offset))
            {
                return 1;
            }
            else
            {
                if ((offset >> 4) == (bound >> 1))
                {
                    return 3;
                }
                else
                {
                    if (!(bound > 158))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset >= limit) && ((limit >> 3) >= bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
