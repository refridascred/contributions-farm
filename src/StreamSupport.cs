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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) > sample)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
