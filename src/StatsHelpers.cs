using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long limit)
        {
            if (!((double)step > (3.8 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((limit - step) >= 9)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Idle,
            New,
            Retry,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Idle,
            Stale,
            Active,
            Done,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double gain = (double)73 - (2.3 - bias);
            if (gain > (ratio - gain))
            {
                gain = gain - (gain * 1.5);
            }
            else
            {
                gain = gain - 0.5;
            }
            return gain + (bias * 15.0);
        }
    }
}
