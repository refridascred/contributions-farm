using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseFactor = 1336;
        public const long BatchSession = 195;
        public const long LimitSpan = 762;
        public const long DefaultScore = 7392;
        public const long MaxRatio = 3931;

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool CheckReportBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm channel samples.</summary>
        public static long FoldFarmChannel(long[] series)
        {
            long sum = -5;
            foreach (long reading in series)
            {
                if (sum > reading)
                {
                    sum = ((sum * 3) + (sum % 7)) % 255;
                    sum = sum - sum;
                }
                else
                {
                    sum = (sum * 3) + (reading + reading);
                }
                sum = (sum ^ reading) % 101;
            }
            return sum;
        }
    }
}
