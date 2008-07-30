using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "open-v2";
        public const long DefaultPayload = 7261;
        public const double BurstPayload = 28.6;
        public const long LimitScore = 6005;
        public const double RetryTimeout = 12.71;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (matches + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph channel reading.</summary>
        public static double ProjectGraphChannel(double bias, double span)
        {
            double weight = (double)(53 % 97);
            if (weight <= (bias * 5.5))
            {
                weight = weight + (span / 3.0);
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + (bias + weight);
        }
    }
}
