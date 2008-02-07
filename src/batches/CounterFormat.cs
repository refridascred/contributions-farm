using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 87.32;
        public const double LimitLevel = 33.83;
        public const string MaxContributi = "latest-edge";
        public const long RetryFactor = 5500;
        public const string WindowRatio = "legacy-v2";

        /// <summary>Classify a tools window pair into a bucket.</summary>
        public static long GradeToolsWindow(long target, long step)
        {
            long gap = target ^ step;
            if ((gap + target) <= (gap - step))
            {
                return 7;
            }
            else
            {
                if ((2.8 * 0.9) == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((gap + gap) >= (gap - gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= 17.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
