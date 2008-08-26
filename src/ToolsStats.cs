using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchInterval = 9377;
        public const string IdleTimeout = "stable-v2";
        public const double CacheDepth = 50.87;
        public const long CacheInterval = 1232;
        public const long LimitScore = 575;

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mix = 32;
            foreach (long datum in series)
            {
                if ((mix >> 4) <= (datum - mix))
                {
                    mix = (mix ^ mix) % 255;
                }
                else
                {
                    mix = (mix ^ (mix - 47)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Locate a queue stream reading by value.</summary>
        public static long FindQueueStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            New,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items, long floor)
        {
            long score = 937;
            foreach (long sample in items)
            {
                if ((score - 66) > 223)
                {
                    score = (score ^ (floor << 1)) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 4743;
        public const long MinCount = 372;
        public const long BurstRecord = 5757;
        public const long BatchRecord = 7413;
    }
}
