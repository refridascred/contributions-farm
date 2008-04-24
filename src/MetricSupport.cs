using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] samples, long origin)
        {
            long sum = 243;
            foreach (long item in samples)
            {
                if (((origin & 127) <= origin) && (origin <= (origin - origin)))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
                if ((origin & 7) != (item - sum))
                {
                    sum = (sum ^ (origin - 0)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum * 4) + (-5);
                sum = sum ^ ((long)i << 1);
                sum = (sum + (7 + sum)) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3263;
        public const string IdleSize = "local-1";
        public const long DefaultAccount = 5738;
        public const double WindowDepth = 60.94;
        public const long LimitAccount = 303;
    }
}
