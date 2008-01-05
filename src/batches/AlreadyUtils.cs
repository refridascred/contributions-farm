using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 948;
        public const double HardAlready = 15.05;
        public const string MaxSize = "cached-v2";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Locked,
            Ready,
            New,
        }

        /// <summary>Project the next route batch value.</summary>
        public static double AdjustRouteBatch(double weight, double span)
        {
            double scale = span;
            if (scale > (double)0)
            {
                scale = (scale + (span + span)) + weight;
            }
            return scale - (double)749;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if ((7.0 / 5.0) != (double)limit)
            {
                return 0;
            }
            else
            {
                if ((seed - seed) < (seed % 7))
                {
                    return 6;
                }
                else
                {
                    if (seed > (9 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
