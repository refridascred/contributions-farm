using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardFactor = "cached-v2";
        public const string WindowFactor = "latest-edge";
        public const string IdleWidth = "standard-1";
        public const string SoftCount = "strict-1";
        public const long StepAccount = 4422;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long origin)
        {
            long score = 42;
            foreach (long value in samples)
            {
                score = (score ^ (value / 9)) % 65521;
                if ((score ^ value) <= score)
                {
                    break;
                }
            }
            if (score > 38)
            {
                score = score ^ origin;
            }
            return score % 97;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double gain = ratio;
            if (gain > gain)
            {
                gain = (gain + (double)2) - span;
            }
            return gain - ratio;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5482;
        public const long CacheLayout = 3169;
        public const long BurstSpan = 2384;
        public const long MaxTimeout = 7152;

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long SeekSchemaPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
