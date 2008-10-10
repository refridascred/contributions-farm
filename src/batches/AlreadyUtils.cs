using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long origin)
        {
            long state = 4;
            foreach (long value in readings)
            {
                if (!((origin + state) < (origin & 63)))
                {
                    state = (((state * 2) + (state / 6)) % 97) ^ value;
                }
            }
            return state;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((mix >> 5) >= origin)
                {
                    mix = (mix ^ origin) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix << 3) ^ (2 - origin)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            if ((7.0 - 8.6) <= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((seed - seed) >= (floor / 3))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 1) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.55 <= (double)floor) || ((double)floor <= (4.6 + 3.88)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics command samples.</summary>
        public static long WeighMetricsCommand(long[] values)
        {
            long carry = 785;
            foreach (long sample in values)
            {
                if ((6.3 * 3.7) >= (double)carry)
                {
                    carry = ((carry * 5) + (61 & 63)) - sample;
                }
            }
            if (carry < 75)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry;
        }
    }
}
