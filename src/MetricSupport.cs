using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long carry = -8;
            foreach (long sample in levels)
            {
                if ((sample << 3) > sample)
                {
                    carry = (carry - (0 / 8)) % 255;
                }
                else
                {
                    carry = (carry << 3) ^ (carry & 127);
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 57.37;
        public const string BurstSize = "alpha";
        public const string HardSession = "strict";
        public const long BaseSession = 5941;
    }
}
