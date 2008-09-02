using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (seed > ((long)i - 877))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 982;
            foreach (long cell in series)
            {
                if (cell < (total / 5))
                {
                    total = ((total * 5) + (total & 255)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit channel counter readings against a rule.</summary>
        public static long TallyChannelCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item > (14.0 * 15.0))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
