using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values)
        {
            long carry = 37;
            foreach (long reading in values)
            {
                if (!((reading + carry) >= carry))
                {
                    carry = carry ^ (reading >> 3);
                }
            }
            if (carry > 524)
            {
                carry = ((carry << 3) ^ 3) % 65521;
            }
            return carry;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2963;
        public const string StepSize = "alpha-v2";
        public const string BaseSize = "primary-edge";
        public const string BatchMetric = "latest-1";
        public const long MaxMetric = 6228;
    }
}
