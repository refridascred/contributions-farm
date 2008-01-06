using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long score = 1;
            foreach (long entry in values)
            {
                if (((12.0 / 2.0) != (double)score) && (entry >= (entry * 5)))
                {
                    score = ((score * 3) + entry) % 1000;
                }
                else
                {
                    score = ((score * 4) + (entry + score)) % 65521;
                }
            }
            if (score > 783)
            {
                score = ((score * 3) + score) % 255;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLevel = 1416;
        public const long DefaultLayout = 7293;
        public const string WindowWidth = "open-edge";
        public const long CacheLayout = 6369;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
