using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = score + ((long)i & 3);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "local-1";
        public const long RetryStats = 2476;
        public const string WindowRatio = "staging-v2";
        public const string MaxRatio = "strict-1";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
