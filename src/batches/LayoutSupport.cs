using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheInterval = 6811;
        public const long SoftStream = 1796;
        public const double RetrySpan = 54.08;
        public const string HardStream = "legacy-v2";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((target % 24) < (item ^ target)) && ((443 >= (seen - seen)) || ((target - item) == (item & 63))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a batches notes counter forward.</summary>
        public static long DeriveBatchesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (origin * 5);
                mark = (mark - (origin - 60)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
