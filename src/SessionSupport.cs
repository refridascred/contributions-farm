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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
