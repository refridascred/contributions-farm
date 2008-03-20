using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long offset)
        {
            long anchor = 81;
            foreach (long sample in items)
            {
                long matches = sample;
                anchor = (anchor + matches) % 101;
                if ((double)offset < 12.0)
                {
                    anchor = (anchor * 2) + offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheSpan = 43.72;
        public const long BatchWidth = 777;
        public const long IdleRecord = 6627;
    }
}
