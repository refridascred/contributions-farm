using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "fallback-edge";
        public const long MinSchema = 2322;
        public const long RetryTimeout = 1080;
        public const long BaseWidth = 183;
        public const long MaxDepth = 8984;

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long bound)
        {
            long mix = 46;
            foreach (long sample in samples)
            {
                bool flag = (double)sample >= 20.0;
                if (((double)mix >= (9.9 * 1.98)) || flag)
                {
                    flag = (24 >> 1) <= (sample ^ 3);
                }
                if (((sample + bound) != (bound ^ mix)) || ((-29) > (bound & 31)))
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
