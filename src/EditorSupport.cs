using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5140;
        public const string BurstGraph = "strict-1";
        public const long BurstLevel = 4407;
        public const long IdleCount = 6318;
        public const double BatchCount = 94.5;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 3692;
        public const long WindowCommand = 8599;
        public const double WindowCount = 59.61;
        public const double BurstFactor = 88.0;
        public const string MaxCommand = "primary";

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepInterval = 7312;
        public const double DefaultFactor = 83.43;
        public const double SoftCount = 62.7;
        public const long MaxGithubfarm = 1362;
        public const double DefaultSize = 31.54;

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool VerifyMetricFarmRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (seed2 <= (seed2 << 2))
            {
                return 8;
            }
            else
            {
                if ((seed2 << 3) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + seed2) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)739 <= (double)seed2)
                        {
                            return 6;
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
}
