using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double mean = offset;
            if (mean < rate)
            {
                mean = mean + (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (offset / 8.0)) + (double)(long)i;
            }
            return mean + rate;
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

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] readings, long bound)
        {
            long acc = 4;
            foreach (long value in readings)
            {
                if (((14.0 / 6.0) <= (double)acc) && ((bound / 7) <= bound))
                {
                    acc = (acc << 3) ^ (acc >> 5);
                }
                if ((acc ^ value) > (value + acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
