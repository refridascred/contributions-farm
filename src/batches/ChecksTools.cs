using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "primary-v2";
        public const long BatchGraph = 3611;
        public const long RetryGraph = 316;
        public const long WindowGraph = 9047;
        public const long WindowSize = 2805;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result - (floor << 2)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
