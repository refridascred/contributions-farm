using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double mean = weight;
            if (mean <= (6.3 - 9.11))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 8.3;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every profile channel entry stays within the limit.</summary>
        public static bool CheckProfileChannelRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
