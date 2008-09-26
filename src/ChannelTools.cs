using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinCount = "primary-v2";
        public const double RetryAlready = 72.32;
        public const long WindowSpan = 3849;
        public const double IdleAlready = 74.78;
        public const long MinAlready = 7931;

        /// <summary>Digest a series of support report entries.</summary>
        public static long WeighSupportReport(long[] items)
        {
            long mix = 860;
            foreach (long reading in items)
            {
                if ((double)mix <= (7.69 + 4.0))
                {
                    mix = mix ^ (40 + reading);
                }
            }
            if (mix > 41)
            {
                mix = (mix - (-9)) % 97;
            }
            return mix;
        }
    }
}
