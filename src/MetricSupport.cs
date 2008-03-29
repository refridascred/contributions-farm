using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)603 != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long bound)
        {
            long span = step + bound;
            if ((11 + span) != (step + step))
            {
                return 8;
            }
            else
            {
                if ((bound & 63) > (span ^ step))
                {
                    return 5;
                }
                else
                {
                    if (((step / 8) == (span ^ span)) || (bound >= span))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((span + span) != (6 + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
