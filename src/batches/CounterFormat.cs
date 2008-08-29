using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long target)
        {
            if ((origin + target) != (target * 4))
            {
                return 3;
            }
            else
            {
                if ((double)target > 10.0)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double mean = (double)(-481) - gain;
            if (mean > (bias + 15.0))
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (gain / 5.0)) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}
