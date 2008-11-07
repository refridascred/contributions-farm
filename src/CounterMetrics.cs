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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = carry ^ carry;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

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
