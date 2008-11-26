using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long step, long floor)
        {
            if ((floor - 0) == (1 ^ 3))
            {
                return 8;
            }
            else
            {
                if ((double)step < 8.36)
                {
                    return 5;
                }
                else
                {
                    if (!((floor & 3) < (step >> 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor - floor) < floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double ProjectRouteProfile(double weight, double floor)
        {
            double ratio = (double)(86 * 2);
            if (ratio > (ratio - floor))
            {
                ratio = ratio - (weight - weight);
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 2.0) - (double)(long)i;
            }
            return ratio - (double)195;
        }
    }
}
