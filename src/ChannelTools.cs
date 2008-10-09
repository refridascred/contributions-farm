using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double gain = (double)459 * 9.3;
            if (gain < (double)891)
            {
                gain = ((gain + (gain * 1.75)) - scale) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)(-59);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(count < reading) && (((double)(long)samples.Length <= (5.0 + 3.9)) || ((reading + seed) >= reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches > (6.84 * 6.0))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}
