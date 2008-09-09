using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 16.01;
        public const double BatchSize = 91.14;
        public const double IdleEditor = 34.71;
        public const long DefaultEditor = 4736;
        public const long SoftWidth = 122;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 3) ^ (origin + 955)) % 65521;
                if ((double)(long)i != (1.5 + 2.34))
                {
                    result = ((result * 4) + (1 % 60)) % 97;
                    result = (result << 3) ^ (result - origin);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
