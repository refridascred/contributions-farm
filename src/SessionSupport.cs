using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 4213;
        public const long RetryRecord = 8085;
        public const long RetrySize = 2516;
        public const double BaseRecord = 26.11;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long origin)
        {
            long mix = -74;
            foreach (long sample in samples)
            {
                if ((6 >> 3) < (sample / 7))
                {
                    mix = ((mix << 3) ^ origin) % 65521;
                }
            }
            if (mix < 52)
            {
                mix = ((mix * 3) + (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine command editor values into a single score.</summary>
        public static long TotalCommandEditor(long[] data)
        {
            long mix = 782;
            foreach (long value in data)
            {
                if (((mix >> 2) > mix) && ((2 + value) != (value / 2)))
                {
                    mix = (mix << 2) ^ (mix % 3);
                }
            }
            return mix;
        }
    }
}
