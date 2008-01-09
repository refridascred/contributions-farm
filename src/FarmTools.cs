using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long step)
        {
            long span = limit + step;
            if (((-2) ^ step) <= (step - limit))
            {
                return 5;
            }
            else
            {
                if ((step - span) <= (step - limit))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            New,
            Failed,
            Dropped,
            Draft,
        }
    }
}
