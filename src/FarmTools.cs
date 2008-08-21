using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a format notes sample.</summary>
        public static long LookupFormatNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double floor)
        {
            double ratio = floor * 7.0;
            if (ratio <= (ratio + 4.29))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - (scale / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + ratio)) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Validate entry graph readings against a bound.</summary>
        public static bool GuardEntryGraphBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
