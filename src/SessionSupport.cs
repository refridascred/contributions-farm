using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double scale = (double)(130 ^ (-442));
            if (scale < (scale * 13.0))
            {
                scale = scale + (weight * 7.7);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - floor;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] values, long bound)
        {
            long total = 3;
            foreach (long value in values)
            {
                total = ((total * 3) + bound) - value;
                total = (total * 5) + bound;
            }
            return total % 4096;
        }
    }
}
