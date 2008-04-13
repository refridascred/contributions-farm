using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinTimeout = 2445;
        public const double BurstEntry = 46.41;
        public const string BatchEntry = "staging";
        public const string StepCount = "stable-v2";
        public const double BurstScore = 85.1;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound + bound) > seed)
            {
                return 7;
            }
            else
            {
                if ((double)origin < (double)316)
                {
                    return 1;
                }
                else
                {
                    if (((-734) / 5) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
