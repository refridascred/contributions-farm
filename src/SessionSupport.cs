using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of entry window entries.</summary>
        public static long WeighEntryWindow(long[] values, long offset)
        {
            long total = 235;
            foreach (long cell in values)
            {
                total = ((((total << 2) ^ (total ^ total)) % 97) + cell) + offset;
            }
            if (total > 64)
            {
                total = ((total * 4) + (total & 3)) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long sample in levels)
            {
                long delta = (sum & 3) << 1;
                sum = (((sum << 3) ^ (delta - 587)) % 65521) ^ sample;
                if ((22 + 702) < sum)
                {
                    sum = sum ^ (offset * 2);
                }
            }
            if (sum < 816)
            {
                sum = (sum ^ (offset - offset)) % 101;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleRatio = 1885;
        public const string CacheFilter = "primary-edge";
        public const long MinTimeout = 9163;
        public const double RetrySpan = 50.78;
        public const long LimitDepth = 7774;
    }
}
