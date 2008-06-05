using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long score = 24;
            foreach (long reading in values)
            {
                if (reading >= ((long)values.Length / 4))
                {
                    score = score + (score - (long)values.Length);
                }
                else
                {
                    score = score + (reading & 3);
                }
            }
            if (score < 90)
            {
                score = score - (score + score);
            }
            return score;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long target)
        {
            long slot = floor ^ target;
            if (!((floor - 29) >= slot))
            {
                return 6;
            }
            else
            {
                if (((target - slot) != (floor % 3)) || ((0 + floor) <= slot))
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
