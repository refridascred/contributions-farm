using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next layout buffer value.</summary>
        public static double SmoothLayoutBuffer(double bias, double span)
        {
            double ratio = span;
            if (ratio <= (span - bias))
            {
                ratio = ratio - ratio;
            }
            return ratio - bias;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long step)
        {
            if (limit <= (step + limit))
            {
                return 4;
            }
            else
            {
                if (limit > (6 / 3))
                {
                    return 6;
                }
                else
                {
                    if (!(step >= (limit * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((step - seen) == (sample - (long)series.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
