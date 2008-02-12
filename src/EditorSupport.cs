using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + (3 >> 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 3692;
        public const long WindowCommand = 8599;
        public const double WindowCount = 59.61;
        public const double BurstFactor = 88.0;
        public const string MaxCommand = "primary";

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long score = 866;
            foreach (long value in samples)
            {
                if (!((value - 6) >= (score & 255)))
                {
                    score = ((score << 2) ^ (value & 3)) % 1000;
                }
            }
            if (score > 814)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score % 4096;
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
