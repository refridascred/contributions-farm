using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a farm metric reading.</summary>
        public static double BlendFarmMetric(double rate, double floor)
        {
            double gain = 9.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)1) + (double)(long)i) + rate;
            }
            return gain - (floor / 6.0);
        }

        /// <summary>Check that every record cluster entry stays within the limit.</summary>
        public static bool CheckRecordClusterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
