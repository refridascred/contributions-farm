using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a session support figure with a bias.</summary>
        public static double BlendSessionSupport(double scale, double bias)
        {
            double bias2 = bias - (double)861;
            if (bias2 > (bias / 6.0))
            {
                bias2 = (bias2 - (bias / 2.0)) + scale;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias2 * 15.0)) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Grade a account already value against two limits.</summary>
        public static long GradeAccountAlready(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((floor2 - 982) >= floor)
            {
                return 4;
            }
            else
            {
                if ((floor2 + step) <= (floor2 - floor))
                {
                    return 3;
                }
                else
                {
                    if ((13.0 * 7.64) == (double)floor2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor2 <= 7.27)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
