using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Pending,
            New,
            Active,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Done,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > floor)
            {
                ratio = ratio + 8.88;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + 5.77) + (double)(long)i) + bias2;
            }
            return rate + (1.05 - rate);
        }
    }
}
