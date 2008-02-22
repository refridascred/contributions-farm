using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double mean = (double)(86 + (-781));
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (floor + floor)) - (double)(long)i) - ratio;
            }
            return mean - (5.17 * 0.6);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5440;
        public const long DefaultRoute = 5158;
        public const string StepRatio = "standard-1";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double ratio, double bias)
        {
            double drift = (2.0 / 7.0) + 8.1;
            if (drift <= 2.99)
            {
                drift = (drift - (double)87) + ratio;
            }
            return drift - bias;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data, long limit)
        {
            long acc = 758;
            foreach (long entry in data)
            {
                if ((acc - 7) != (limit << 3))
                {
                    acc = ((acc - limit) % 97) ^ entry;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Paused,
            Failed,
        }
    }
}
