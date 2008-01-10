using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseRatio = 95.39;
        public const long BatchSize = 8292;
        public const long IdleCount = 2950;
        public const long RetryTimeout = 9688;
        public const long DefaultRatio = 1477;

        /// <summary>Roll a support stream counter forward.</summary>
        public static long IterateSupportStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor << 2) ^ (anchor - origin)) % 4096) + (long)i2;
                    anchor = (anchor - anchor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
