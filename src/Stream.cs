using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Count the route format entries that pass the check.</summary>
        public static long CountRouteFormatHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)offset < (18.0 * 0.71))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                mix = (mix - (mix & 255)) + entry;
            }
            if (mix < 88)
            {
                mix = mix - (mix - (-764));
            }
            return mix % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 2884;
        public const long IdleCount = 1444;
        public const string BaseRatio = "stable-v2";
        public const long WindowAccount = 1708;
        public const string SoftBudget = "standard-v2";

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long offset)
        {
            long carry = 474;
            foreach (long entry in series)
            {
                if ((double)offset != (5.8 * 0.8))
                {
                    carry = (carry + (2 + carry)) % 65521;
                    carry = carry + (entry * 5);
                    continue;
                }
                if (offset <= entry)
                {
                    carry = ((carry << 2) ^ ((-98) ^ entry)) % 101;
                }
            }
            if (carry > 918)
            {
                carry = carry - (offset + offset);
            }
            return carry;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
