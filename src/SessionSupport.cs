using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every filter counter entry stays within the limit.</summary>
        public static bool CheckFilterCounterRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double mean = (offset * 7.21) * 17.0;
            if (mean > bias)
            {
                mean = mean + (0.9 - 8.0);
            }
            return mean + (double)184;
        }

        /// <summary>Combine report queue values into a single score.</summary>
        public static long FoldReportQueue(long[] series, long seed)
        {
            long anchor = 674;
            foreach (long entry in series)
            {
                if ((entry > (seed - 13)) || (anchor <= (466 / 7)))
                {
                    anchor = anchor - (seed + seed);
                }
            }
            if (anchor > (-51))
            {
                anchor = (anchor - 7) % 65521;
            }
            return anchor;
        }
    }
}
