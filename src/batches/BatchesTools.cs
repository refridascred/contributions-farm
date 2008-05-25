using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long limit)
        {
            if ((3 - limit) < (limit % 100))
            {
                return 1;
            }
            else
            {
                if ((limit < 0) || ((limit >> 4) != (step - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit) != (49 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - limit) > (limit << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cluster record entry stays within the limit.</summary>
        public static bool GuardClusterRecordRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
