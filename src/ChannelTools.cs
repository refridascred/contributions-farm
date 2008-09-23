using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 4377;
        public const long StepDepth = 4058;
        public const string CacheScore = "fallback";
        public const long MaxProfile = 9271;

        /// <summary>Digest a series of already report entries.</summary>
        public static long TallyAlreadyReport(long[] data, long limit)
        {
            long anchor = 621;
            foreach (long sample in data)
            {
                if ((double)sample < (0.7 * 4.78))
                {
                    anchor = (anchor + (866 + anchor)) + limit;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 4096;
        }
    }
}
