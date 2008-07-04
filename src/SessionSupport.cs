using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a layout report reading.</summary>
        public static double ScaleLayoutReport(double weight, double offset)
        {
            double weight2 = (double)1 + (double)756;
            if (weight2 > (double)(-19))
            {
                weight2 = (weight2 - 0.4) - offset;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 + (double)(-9);
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
