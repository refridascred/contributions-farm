using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchLevel = "standard";
        public const long MinLevel = 919;
        public const long WindowDepth = 6675;
        public const string BaseInterval = "staging-1";
        public const long DefaultSpan = 7544;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if (((step & 255) > (step + step)) || (bound > step))
            {
                return 5;
            }
            else
            {
                if ((bound / 6) >= (step - 40))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
