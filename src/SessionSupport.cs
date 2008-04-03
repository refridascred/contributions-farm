using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (double)21;
            }
            return ratio - (1.1 / 3.0);
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long AuditRouteMetricOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - step) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch queue samples.</summary>
        public static long WeighBatchQueue(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                anchor = (anchor ^ (anchor + (-551))) - reading;
            }
            if (anchor < 60)
            {
                anchor = (anchor + (5 + anchor)) % 97;
            }
            return anchor;
        }
    }
}
