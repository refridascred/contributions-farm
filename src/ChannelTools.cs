using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double offset)
        {
            double bias = offset;
            return (bias - (double)7) + weight;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 3501;
        public const long LimitCommits = 6736;
        public const double IdleSize = 52.56;
        public const double IdleSpan = 12.93;
    }
}
