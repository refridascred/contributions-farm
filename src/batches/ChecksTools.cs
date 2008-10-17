using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryFactor = 77.41;
        public const long MinWidth = 6191;
        public const double CacheCount = 54.4;
        public const string BatchBudget = "strict-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 12.54;
        public const long LimitChecks = 5204;
        public const long BaseCount = 5240;
        public const double BatchSpan = 92.22;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long origin)
        {
            if (3.42 > (double)seed)
            {
                return 8;
            }
            else
            {
                if ((origin / 4) > (9 + origin))
                {
                    return 2;
                }
                else
                {
                    if (((seed + 590) > (seed + seed)) || ((15.0 / 6.0) <= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((402 + seed) >= origin) && ((18 + seed) >= origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
