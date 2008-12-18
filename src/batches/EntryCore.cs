using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (floor * 4.99))
            {
                ratio = ratio + (floor - ratio);
            }
            else
            {
                ratio = ratio + (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)82) + (double)(long)i;
            }
            return ratio + (2.76 / 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxLevel = 8979;
        public const long LimitBuffer = 9330;
        public const string CacheBuffer = "fallback-1";
        public const double BatchWidth = 69.12;

        /// <summary>Define account limits and defaults.</summary>
        public const double StepFactor = 31.87;
        public const string BatchAccount = "strict-edge";
        public const long MaxAccount = 6944;

        /// <summary>Count already githubfarm pairs that satisfy a relation.</summary>
        public static long MatchAlreadyGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
