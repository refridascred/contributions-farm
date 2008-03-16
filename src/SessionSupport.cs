using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two report command measurements.</summary>
        public static double AdjustReportCommand(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 18.0) + (double)(long)i;
            }
            return ratio + floor;
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
