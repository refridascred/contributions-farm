using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 8711;
        public const long LimitRecord = 6817;
        public const long DefaultRecord = 7696;
        public const double BaseInterval = 18.89;

        /// <summary>Look up the position of a metrics graph sample.</summary>
        public static long SeekMetricsGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token session counter forward.</summary>
        public static long StepTokenSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry << 2) ^ (origin + origin)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
