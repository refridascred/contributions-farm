using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a tools checks reading.</summary>
        public static double ScaleToolsChecks(double weight, double span)
        {
            double weight2 = (double)58 - (span / 5.0);
            if (weight2 > (weight2 / 5.0))
            {
                weight2 = weight2 + (weight2 - 6.4);
            }
            else
            {
                weight2 = weight2 - (weight * 2.3);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight / 5.0)) + (double)(long)i;
            }
            return weight2 + (double)390;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 2784;
        public const double DefaultAlready = 14.35;
        public const double LimitCount = 35.42;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Stale,
            New,
            Pending,
        }
    }
}
