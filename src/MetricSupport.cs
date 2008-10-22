using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryCount = 5243;
        public const double WindowFactor = 38.52;
        public const string DefaultLevel = "primary";
        public const long SoftFactor = 6128;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] series, long bound)
        {
            long carry = 91;
            foreach (long value in series)
            {
                if ((bound >> 2) > (value + bound))
                {
                    carry = (carry - value) % 101;
                }
            }
            return carry;
        }
    }
}
