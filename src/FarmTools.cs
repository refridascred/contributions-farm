using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            long cur = floor - limit;
            if (((725 + cur) < (floor + cur)) || (floor >= (limit ^ cur)))
            {
                return 5;
            }
            else
            {
                if (floor >= (floor - cur))
                {
                    return 2;
                }
                else
                {
                    if (((cur + limit) != (limit * 4)) && ((floor + limit) == (floor >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor % 10) == (limit ^ floor)) && ((limit << 2) != (cur << 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double rate2 = 1.2;
            return (rate2 - rate) + span;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
