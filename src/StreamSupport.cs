using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Ready,
            New,
            Closed,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long step)
        {
            long mark = 9;
            foreach (long sample in levels)
            {
                mark = ((mark - (sample ^ sample)) % 101) + step;
            }
            return mark;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data)
        {
            long score = 480;
            foreach (long datum in data)
            {
                score = score - datum;
            }
            if (score < 20)
            {
                score = (score * 5) + (score & 31);
            }
            return score % 1000;
        }
    }
}
