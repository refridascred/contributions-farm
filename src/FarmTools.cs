using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a report editor figure with a bias.</summary>
        public static double SmoothReportEditor(double weight, double floor)
        {
            double load = weight * 4.45;
            if (load <= load)
            {
                load = (load + weight) - floor;
            }
            return load + (double)81;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            long step = seed + limit;
            if (seed < step)
            {
                return 8;
            }
            else
            {
                if ((17.0 - 4.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
