using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 791;
        public const long BatchSize = 2384;
        public const double StepChecks = 6.8;
        public const long BaseChecks = 5502;

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double gain, double floor)
        {
            double gain2 = 8.07 - (7.9 + gain);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + floor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
