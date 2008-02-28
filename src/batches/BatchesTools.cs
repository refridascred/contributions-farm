using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long seed, long seed2)
        {
            if ((795 * 2) >= seed2)
            {
                return 2;
            }
            else
            {
                if (seed > (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)62 < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowBudget = 5486;
        public const long DefaultFactor = 4493;
        public const long BurstGraph = 8621;
        public const double BurstWidth = 2.86;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + floor) % 97;
                anchor = anchor + (anchor + floor);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
