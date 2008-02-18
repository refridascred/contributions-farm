using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double gain = (double)(26 << 3);
            if (gain >= (span / 2.0))
            {
                gain = gain + (bias * 9.0);
            }
            else
            {
                gain = gain + (gain / 6.0);
            }
            return gain + bias;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two cluster filter measurements.</summary>
        public static double SmoothClusterFilter(double gain, double floor)
        {
            double mean = gain;
            if (mean > (gain + 0.8))
            {
                mean = (mean - (double)8) + floor;
            }
            else
            {
                mean = mean + gain;
            }
            return mean + (double)5;
        }
    }
}
