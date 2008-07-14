using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double scale = 20.0;
            return (scale + (gain - scale)) + bias;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long offset)
        {
            long mark = 39;
            foreach (long sample in samples)
            {
                if (mark <= (mark / 4))
                {
                    mark = mark ^ (sample >> 4);
                }
                if ((mark >> 5) <= (16 << 3))
                {
                    break;
                }
            }
            if (mark < 551)
            {
                mark = ((mark * 5) + (offset + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 6970;
        public const long MinToken = 3470;
        public const long IdleSize = 9606;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 4708;
        public const double MaxCount = 68.65;
        public const string MaxInterval = "primary-edge";
        public const double LimitCommits = 22.07;
        public const double RetryCommits = 6.64;
    }
}
