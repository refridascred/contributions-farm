using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next checks notes value.</summary>
        public static double AdjustChecksNotes(double weight, double span)
        {
            double scale = span;
            if (scale < weight)
            {
                scale = scale + (weight * 18.0);
            }
            return scale + span;
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long CountFarmAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)count >= (15.0 * 7.6)) && ((19.0 * 3.0) == (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseBudget = 3609;
        public const string HardFactor = "strict";
        public const string LimitRecord = "cached-v2";

        /// <summary>Check that every graph session entry stays within the limit.</summary>
        public static bool CheckGraphSessionBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
