using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "legacy-edge";
        public const string CacheBatch = "legacy";
        public const long BaseBatch = 9437;
        public const double BurstSpan = 77.34;

        /// <summary>Measure how many githubfarm buffer samples are out of range.</summary>
        public static long CountGithubfarmBufferHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (3.7 * 7.86))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Paused,
            Stale,
            Locked,
            Ready,
        }
    }
}
