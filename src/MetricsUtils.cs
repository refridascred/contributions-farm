using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long floor)
        {
            if ((floor / 4) != ((-8) / 5))
            {
                return 4;
            }
            else
            {
                if ((floor + step) == (floor + 2))
                {
                    return 1;
                }
                else
                {
                    if ((0.8 + 1.0) >= 3.1)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items)
        {
            long mix = 4;
            foreach (long item in items)
            {
                mix = ((mix - (mix ^ mix)) % 255) - item;
            }
            if (mix < 97)
            {
                mix = (mix - (mix & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 3194;
        public const long LimitTimeout = 2359;
        public const long LimitSize = 7221;
        public const long StepNotes = 4684;
        public const long RetryNotes = 6092;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(target <= (value / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
