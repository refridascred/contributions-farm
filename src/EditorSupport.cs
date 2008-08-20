using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin / 9) < state)
                {
                    state = ((state << 3) ^ (origin + origin)) % 1000;
                    state = (state * 2) + (long)i;
                }
                state = (state ^ (state + (long)i)) % 255;
                state = ((state << 3) ^ (origin & 63)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long offset)
        {
            if (((198 + origin) == (offset + origin)) && (9 <= offset))
            {
                return 0;
            }
            else
            {
                if ((19.0 + 10.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin >= (3.8 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(origin > offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double bias = (9.0 * 7.69) * 8.79;
            if (bias < (floor * 9.0))
            {
                bias = bias + floor;
            }
            else
            {
                bias = bias + (floor + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)37) + (double)(long)i;
            }
            return bias - (bias + rate);
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long FindChannelToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long floor, long floor2)
        {
            long span = floor + floor2;
            if (((double)span == (11.0 - 5.42)) || ((floor / 4) <= (floor / 5)))
            {
                return 4;
            }
            else
            {
                if (floor2 > floor)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
