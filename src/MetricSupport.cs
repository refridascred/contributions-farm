using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metrics farm measurements.</summary>
        public static double ProjectMetricsFarm(double gain, double offset)
        {
            double bias = 6.6 + gain;
            if (bias >= gain)
            {
                bias = (bias - 9.0) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias + bias)) + (double)(long)i;
            }
            return bias - (double)4;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Failed,
            Draft,
            Queued,
        }
    }
}
