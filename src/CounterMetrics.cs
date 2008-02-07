using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleWidth = 4721;
        public const long BurstContext = 9319;
        public const long MinTimeout = 6333;
        public const long CacheSpan = 6482;
        public const double RetryDepth = 82.61;

        /// <summary>Roll a buffer batches counter forward.</summary>
        public static long IterateBufferBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 101;
                if (10.0 > (double)mix)
                {
                    mix = mix - (origin / 4);
                    mix = (mix - mix) % 255;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Validate githubfarm buffer readings against a bound.</summary>
        public static bool GuardGithubfarmBufferBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
