using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (cell + (long)levels.Length)) && (((cell % 100) == (cell % 2)) || ((tally * 3) <= (tally - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double bias = (gain - 0.27) * 1.3;
            if (bias < floor)
            {
                bias = bias + (bias * 1.2);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias - bias)) + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long target)
        {
            long gap = limit ^ target;
            if (!((target >> 2) >= (target / 2)))
            {
                return 3;
            }
            else
            {
                if ((target << 1) != (gap & 15))
                {
                    return 6;
                }
                else
                {
                    if (((limit << 1) == (12 - limit)) && ((double)gap > (8.8 * 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)gap < 0.44) || (target <= 94))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
