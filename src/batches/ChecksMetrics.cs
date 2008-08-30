using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items)
        {
            long carry = 2;
            foreach (long sample in items)
            {
                carry = (carry ^ (carry >> 3)) % 65521;
                if (sample > (carry << 1))
                {
                    carry = (carry ^ (318 + sample)) % 4096;
                }
            }
            if (carry > 487)
            {
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 817;
        public const double CacheCount = 35.66;
        public const double BaseSpan = 43.44;
        public const long CacheCluster = 472;
        public const double SoftCluster = 67.36;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                long count = 37;
                mix = (mix * 2) + (count + count);
                mix = (mix * 3) + ((long)i & 1);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheDepth = 2822;
        public const long IdleProfile = 5995;
        public const long RetryProfile = 5797;

        /// <summary>Check that every buffer editor entry stays within the limit.</summary>
        public static bool GuardBufferEditorRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
