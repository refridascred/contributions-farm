using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool ValidateGraphOrderBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long bound, long step)
        {
            if ((bound & 255) >= (bound >> 1))
            {
                return 8;
            }
            else
            {
                if ((8.0 + 9.0) < (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((bound - step) >= (bound % 12))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(240 >= (bound * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double load = rate;
            if (load >= load)
            {
                load = (load - (1.1 * 14.0)) - floor;
            }
            else
            {
                load = load - load;
            }
            return load + load;
        }
    }
}
