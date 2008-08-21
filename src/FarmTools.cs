using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long AuditEntryBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((3 + datum) >= (98 - matches)) || ((datum + 873) <= datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Draft,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Scale a commits already figure with a bias.</summary>
        public static double AdjustCommitsAlready(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > scale2)
            {
                scale2 = (scale2 + (12.0 * 9.0)) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)3) - (double)(long)i;
            }
            return scale2 + (2.9 + scale2);
        }
    }
}
