using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double mean = (double)(45 + 508);
            return (mean + offset) + gain;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(reading <= (reading >> 1)) && (((reading / 9) == (reading << 3)) || (1 <= (reading - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
