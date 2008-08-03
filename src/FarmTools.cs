using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Done,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double gain = span;
            if (gain < (span * 17.0))
            {
                gain = gain + (scale - span);
            }
            else
            {
                gain = gain + (scale * 7.9);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (gain - 6.4);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if ((datum >> 4) < datum)
                {
                    anchor = ((anchor << 3) ^ datum) % 97;
                }
                else
                {
                    anchor = (anchor + datum) % 4096;
                }
            }
            return anchor % 65521;
        }
    }
}
