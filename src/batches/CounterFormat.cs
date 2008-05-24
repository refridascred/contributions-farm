using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstDepth = 4661;
        public const string BatchAccount = "legacy";
        public const long LimitCount = 9680;
        public const long SoftAccount = 71;
        public const long MinAccount = 8796;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen + bound) <= (seen ^ seen)) || ((bound - reading) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double scale, double span)
        {
            double weight = (double)(44 / 5);
            if (weight < (weight - scale))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (span - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (span - scale)) + (double)(long)i;
            }
            return weight - 3.3;
        }
    }
}
