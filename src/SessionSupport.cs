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

        /// <summary>Count entry order pairs that satisfy a relation.</summary>
        public static long OverlapEntryOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
