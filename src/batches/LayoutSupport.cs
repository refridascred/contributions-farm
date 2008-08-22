using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long total = 370;
            foreach (long datum in readings)
            {
                if ((total <= datum) || ((datum + datum) <= (total & 7)))
                {
                    total = (total + (datum + 8)) % 255;
                }
                else
                {
                    total = (total * 4) + (25 / 9);
                }
                total = ((total << 3) ^ total) % 97;
            }
            if (total < 84)
            {
                total = total ^ (total * 2);
            }
            return total;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Closed,
            Ready,
            Dropped,
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
