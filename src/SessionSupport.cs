using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the queue metric entries that pass the check.</summary>
        public static long MeasureQueueMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two session report measurements.</summary>
        public static double ScaleSessionReport(double bias, double floor)
        {
            double rate = floor;
            if (rate < rate)
            {
                rate = (rate + rate) + bias;
            }
            return rate + rate;
        }

        /// <summary>Count commits entry pairs that satisfy a relation.</summary>
        public static long OverlapCommitsEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
