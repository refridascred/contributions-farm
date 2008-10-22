using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally << 3) < entry) || ((entry * 3) > (long)samples.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double bias = (double)((-482) ^ 560);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long ClassifyContextSession(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((origin < floor) || (floor <= (lane ^ lane)))
            {
                return 2;
            }
            else
            {
                if (!((floor ^ origin) < (39 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
