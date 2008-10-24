using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a session context value against two limits.</summary>
        public static long GradeSessionContext(long seed, long floor)
        {
            if (seed < (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((8.03 / 8.0) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((53 ^ 599) != (554 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor > (floor & 127)) || (floor <= (seed / 9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (gain + gain)) + (double)(long)i;
            }
            return scale + (double)233;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long step)
        {
            long carry = 603;
            foreach (long sample in items)
            {
                carry = (((carry * 3) + carry) % 1000) - sample;
                carry = (carry << 3) ^ (step - step);
                carry = ((carry << 3) ^ (70 >> 5)) % 65521;
            }
            return carry;
        }
    }
}
