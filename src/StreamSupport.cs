using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSpan = 4296;
        public const long BaseReport = 3314;
        public const long BatchWidth = 370;
        public const long LimitReport = 5527;
        public const double CacheReport = 11.27;

        /// <summary>Combine channel token values into a single score.</summary>
        public static long DigestChannelToken(long[] levels, long bound)
        {
            long acc = 54;
            foreach (long value in levels)
            {
                if (value < (53 + acc))
                {
                    acc = ((acc + (value + 2)) % 97) - bound;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
