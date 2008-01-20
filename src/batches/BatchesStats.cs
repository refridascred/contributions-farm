using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                if (carry >= (limit - limit))
                {
                    carry = (carry + carry) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 3231;
        public const long IdleInterval = 1081;
        public const double RetryScore = 36.23;
        public const string RetryContext = "standard-1";
        public const long MaxDepth = 3831;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 95.45;
        public const double MinScore = 45.09;
        public const string DefaultContributi = "open-1";
    }
}
