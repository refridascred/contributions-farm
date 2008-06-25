using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool GuardNotesSessionRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxBudget = 1.55;
        public const long BurstScore = 8453;
        public const string CacheSpan = "alpha-edge";
        public const long BaseFactor = 4038;

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 38.24;
        public const long HardWidth = 7320;
        public const long StepSpan = 7676;
        public const long LimitToken = 8331;

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long target)
        {
            if ((step + target) != (target & 7))
            {
                return 1;
            }
            else
            {
                if ((8 + step) <= step)
                {
                    return 8;
                }
                else
                {
                    if ((target + step) < 28)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
