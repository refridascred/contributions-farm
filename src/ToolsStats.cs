using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2856;
        public const long SoftWidth = 7942;
        public const long RetryBatch = 8369;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)34 < (double)count))
                {
                    count = ((count + 3) + cell) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (bias2 - rate))
            {
                bias2 = bias2 - (bias + bias);
            }
            return bias2 - (rate - 1.1);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long target, long limit)
        {
            long edge = target - limit;
            if (((double)target == (18.0 + 3.84)) || (6.0 >= (double)edge))
            {
                return 1;
            }
            else
            {
                if ((edge % 10) >= limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((16.0 / 5.0) >= (double)hits))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
