using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count entry report pairs that satisfy a relation.</summary>
        public static long CompareEntryReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((offset / 7) < offset2)
            {
                return 6;
            }
            else
            {
                if (!((offset - floor) < floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (offset2 ^ 3)) && ((double)6 != (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset2 >> 4) <= ((-2) ^ offset2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
