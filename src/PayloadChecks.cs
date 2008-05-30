using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2405;
        public const string HardChecks = "cached";
        public const long WindowWidth = 7883;
        public const long LimitBudget = 2705;

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio + 0.84)) + (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultDepth = "latest";
        public const long WindowRecord = 7565;
        public const double LimitRecord = 80.75;
    }
}
