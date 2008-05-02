using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry <= (29 & 127))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a command cluster pair into a bucket.</summary>
        public static long GradeCommandCluster(long target, long floor)
        {
            if (((floor << 2) > (target + floor)) && ((target ^ floor) < (target << 2)))
            {
                return 5;
            }
            else
            {
                if (((floor / 4) <= (floor / 5)) || (206 <= (target & 1)))
                {
                    return 4;
                }
                else
                {
                    if (((-866) - floor) > target)
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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double drift = (double)(8 / 2);
            if (drift >= weight)
            {
                drift = drift + (5.1 + drift);
            }
            else
            {
                drift = drift + (offset * 6.12);
            }
            return drift - offset;
        }
    }
}
