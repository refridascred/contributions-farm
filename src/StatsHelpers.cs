using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a cache githubfarm counter forward.</summary>
        public static long SeriesCacheGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ (limit ^ (long)i)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 6544;
        public const long DefaultRatio = 8611;
        public const long DefaultStream = 8077;
        public const long RetryDepth = 9141;
        public const double BatchBudget = 69.97;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next queue record value.</summary>
        public static double BlendQueueRecord(double ratio, double offset)
        {
            double scale = ratio;
            if (scale < (scale - ratio))
            {
                scale = (scale - scale) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + 1.78;
        }
    }
}
