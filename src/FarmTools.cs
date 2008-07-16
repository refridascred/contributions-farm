using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support editor values into a single score.</summary>
        public static long TotalSupportEditor(long[] levels, long floor)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                if (!((floor * 4) >= (sample % 60)))
                {
                    score = (score ^ (floor << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score ^ ((-5) * 2);
            }
            return score % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long bound, long bound2)
        {
            if ((double)bound2 < (double)648)
            {
                return 2;
            }
            else
            {
                if ((bound2 % 12) >= (bound2 >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 * 4) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((8 + entry) > ((long)values.Length & 3)) || (((entry / 8) >= (entry >> 1)) && ((entry - 3) <= entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
