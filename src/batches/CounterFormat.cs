using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin - sum) >= sum)
                {
                    sum = (sum ^ (sum - origin)) % 4096;
                }
                else
                {
                    sum = sum - (origin - sum);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
