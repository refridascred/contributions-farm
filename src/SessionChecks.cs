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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - count) != (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
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
