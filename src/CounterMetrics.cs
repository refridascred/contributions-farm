using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "primary-1";
        public const double BatchBudget = 11.01;
        public const long IdleRecord = 4918;

        /// <summary>Roll a channel contributi counter forward.</summary>
        public static long StepChannelContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if (!(((double)target > (8.8 / 8.0)) || ((target % 16) >= (4 / 5))))
                {
                    score = (score - ((long)i / 7)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "primary-1";
        public const string MinReport = "cached-edge";
        public const long CacheReport = 4971;
        public const string BaseReport = "legacy-1";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (32 * 4)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
