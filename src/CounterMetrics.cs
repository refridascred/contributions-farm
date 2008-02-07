using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1643;
        public const long CacheLevel = 7979;
        public const string CacheProfile = "local-edge";
        public const long LimitProfile = 7614;
        public const string BaseSpan = "strict-1";

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
