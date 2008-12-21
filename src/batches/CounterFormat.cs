using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9154;
        public const double WindowDepth = 60.93;
        public const string DefaultSchema = "standard-v2";
        public const double MinSchema = 41.65;
        public const long WindowSchema = 9688;

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 31.32;
        public const long MinCommits = 5417;
        public const long BurstSize = 241;

        /// <summary>Classify a stream filter pair into a bucket.</summary>
        public static long ClassifyStreamFilter(long origin, long offset)
        {
            if ((19.0 * 1.0) != (double)origin)
            {
                return 6;
            }
            else
            {
                if (((20.0 - 4.0) < (double)origin) && ((offset / 9) < origin))
                {
                    return 2;
                }
                else
                {
                    if (origin < (43 - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 % 7) >= (origin * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
