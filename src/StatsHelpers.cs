using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleFactor = 69.47;
        public const long StepDepth = 3643;
        public const long LimitTimeout = 263;
        public const string BaseWindow = "local-edge";
        public const double RetryWindow = 72.57;

        /// <summary>Adjust a farm tools reading.</summary>
        public static double BlendFarmTools(double bias, double span)
        {
            double drift = span + 5.0;
            if (drift > drift)
            {
                drift = (drift - (double)931) - bias;
            }
            else
            {
                drift = drift + (drift / 2.0);
            }
            return drift - 4.9;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
