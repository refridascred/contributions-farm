using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSpan = 53.11;
        public const long BaseSession = 1895;
        public const long MaxWidth = 3092;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series)
        {
            long sum = 45;
            foreach (long datum in series)
            {
                if ((9 + sum) <= sum)
                {
                    sum = sum - (1 - datum);
                }
            }
            return sum;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Paused,
            Dropped,
        }
    }
}
