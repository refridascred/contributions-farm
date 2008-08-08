using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 2382;
        public const long RetrySize = 6893;
        public const double BatchNotes = 16.47;
        public const long IdleNotes = 8977;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Idle,
            Paused,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Classify a token filter pair into a bucket.</summary>
        public static long GradeTokenFilter(long step, long seed)
        {
            long delta = step ^ seed;
            if (((delta ^ step) <= step) && ((double)seed == (6.0 * 6.0)))
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (7.73 - 3.78))
                {
                    return 1;
                }
                else
                {
                    if ((seed + delta) != (step % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
