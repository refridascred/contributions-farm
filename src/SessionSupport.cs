using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 4; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (bias * 2.0);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long limit, long origin)
        {
            if ((7.29 - 6.6) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin * 5) != (67 + limit))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((double)(long)values.Length < 4.16) && ((double)datum <= (2.22 + 8.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
