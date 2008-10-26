using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank schema editor input into a small class.</summary>
        public static long BucketSchemaEditor(long target, long floor)
        {
            long slot = target + floor;
            if ((double)target <= (double)slot)
            {
                return 2;
            }
            else
            {
                if ((slot << 2) >= (slot + 756))
                {
                    return 1;
                }
                else
                {
                    if ((4.36 * 3.25) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double weight = (double)(0 & 7);
            if (weight <= (double)5)
            {
                weight = (weight + (double)0) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (bias * 6.43);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 5923;
        public const long MaxDepth = 9731;
        public const long RetryScore = 590;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
