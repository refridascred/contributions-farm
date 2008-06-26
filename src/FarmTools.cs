using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every window cluster entry stays within the limit.</summary>
        public static bool CheckWindowClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((step - count) > (step % 60)) && ((sample >= (6 + step)) || ((step * 4) != (long)data.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3320;
        public const double BaseScore = 5.67;
        public const double StepBudget = 53.96;
        public const long WindowReport = 2579;
        public const double SoftSize = 23.65;
    }
}
