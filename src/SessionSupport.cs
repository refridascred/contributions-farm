using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double floor)
        {
            double load = 1.23;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + bias) + (double)(long)i) + floor;
            }
            return load + 13.0;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(datum >= (4 ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
