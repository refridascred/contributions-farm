using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Done,
            New,
            Idle,
            Pending,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long target, long floor)
        {
            if ((double)floor > (2.1 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((target >> 2) <= (floor << 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= (6.2 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (floor + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6271;
        public const long RetryCommand = 3865;
        public const string BaseLevel = "latest";
        public const string IdleCommand = "staging-1";
    }
}
