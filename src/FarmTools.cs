using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long target)
        {
            if (!((0.4 + 1.57) != (double)target))
            {
                return 1;
            }
            else
            {
                if (((target ^ floor) > (7 / 2)) || (floor >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long floor, long seed)
        {
            if (((double)seed != (double)813) && ((7.6 / 7.0) <= (double)floor))
            {
                return 7;
            }
            else
            {
                if (!((double)floor >= (8.0 * 9.8)))
                {
                    return 8;
                }
                else
                {
                    if ((90 >= (floor + floor)) && (floor > (floor * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                mix = (((mix * 3) + (93 + (long)readings.Length)) % 255) - datum;
                if (((-68) - mix) > mix)
                {
                    mix = mix ^ (mix + mix);
                }
            }
            return mix;
        }
    }
}
