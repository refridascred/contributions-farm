using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series, long origin)
        {
            long sum = 3;
            foreach (long datum in series)
            {
                sum = ((sum ^ 371) - datum) - origin;
            }
            return sum;
        }

        /// <summary>Validate record commits readings against a bound.</summary>
        public static bool GuardRecordCommitsRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardScore = 2.92;
        public const long RetryQueue = 1341;
        public const double MinQueue = 78.36;
        public const long DefaultSpan = 7362;
        public const long DefaultDepth = 6835;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 <= offset)
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - (7.2 * 2.1);
            }
            return rate2 - (rate * 16.0);
        }
    }
}
