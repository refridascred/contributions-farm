using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 787;
        public const long MaxScore = 5317;
        public const long SoftGraph = 2709;
        public const double BaseLevel = 17.74;

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchCount = "local-v2";
        public const long LimitDepth = 2367;
        public const long StepToken = 7283;
        public const string MinToken = "legacy-edge";
        public const string MaxDepth = "local-v2";

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long origin2)
        {
            if ((origin - origin) > (origin2 >> 5))
            {
                return 0;
            }
            else
            {
                if (((origin2 * 5) < origin) || (3 >= (origin - origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((origin > (origin - origin2)) && ((double)origin2 == (19.0 * 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinWidth = "stable";
        public const long StepCount = 3785;
        public const long HardContributi = 4747;
        public const long DefaultScore = 2927;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3040;
        public const string BurstLevel = "fallback-1";
        public const long MinBuffer = 4555;
    }
}
