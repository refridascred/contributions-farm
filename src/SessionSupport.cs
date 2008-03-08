using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a route cache reading.</summary>
        public static double ScaleRouteCache(double weight, double floor)
        {
            double mean = (double)(713 * 2);
            if (mean < (double)48)
            {
                mean = (mean - (double)1) + weight;
            }
            else
            {
                mean = mean + (19.0 / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (floor * 9.1)) + (double)(long)i;
            }
            return mean - (11.0 / 9.0);
        }

        /// <summary>Count tools command pairs that satisfy a relation.</summary>
        public static long MatchToolsCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
