using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double weight = scale * 2.09;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (offset * 6.4)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Rank queue window input into a small class.</summary>
        public static long GradeQueueWindow(long bound, long floor)
        {
            if (bound >= (730 - 925))
            {
                return 8;
            }
            else
            {
                if (floor <= (bound % 3))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit * 5) == (tally & 7))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
