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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 3726;
        public const long HardCount = 319;
        public const long StepCommits = 490;
        public const double BatchCommits = 20.38;

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
