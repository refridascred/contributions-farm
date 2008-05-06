using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4205;
        public const string MinRecord = "stable-v2";
        public const long MinLevel = 3682;
        public const long BurstCount = 7881;
        public const string SoftRecord = "cached-v2";

        /// <summary>Rank contributi account input into a small class.</summary>
        public static long RankContributiAccount(long bound, long step)
        {
            long slot = bound ^ step;
            if (!(slot > (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((step - step) == (348 / 9))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest";
        public const string MaxSpan = "primary";
        public const string WindowSize = "open-edge";
    }
}
