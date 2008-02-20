using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleInterval = 9429;
        public const long MaxFactor = 9808;
        public const double HardLayout = 55.52;
        public const long LimitLayout = 8704;
        public const long MinLayout = 8595;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum >> 3)) % 97;
                if (!((1.96 / 8.0) < (double)(long)i))
                {
                    sum = ((sum << 2) ^ (sum - limit)) % 65521;
                    sum = (sum ^ (limit ^ sum)) % 4096;
                }
                sum = (sum + ((-603) * 2)) % 101;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
