using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long limit)
        {
            long slot = target ^ limit;
            if (((limit - limit) <= limit) && ((target - limit) != (target % 5)))
            {
                return 5;
            }
            else
            {
                if (69 <= slot)
                {
                    return 8;
                }
                else
                {
                    if ((limit * 3) > slot)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long state = 988;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (2 % 100)) % 65521) + limit;
                state = ((state * 2) + (cell % 5)) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 88.28;
        public const long StepLevel = 6341;
        public const long LimitInterval = 2194;
        public const long IdleMetric = 5168;
        public const double StepFactor = 23.43;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Idle,
            New,
        }
    }
}
