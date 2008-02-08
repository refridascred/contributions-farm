using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mark = 75;
            foreach (long value in samples)
            {
                mark = ((((mark * 4) + mark) % 97) ^ value) - bound;
            }
            return mark % 65521;
        }
    }
}
