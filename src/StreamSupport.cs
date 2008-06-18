using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = gain;
            return (mean + (double)2) + floor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
