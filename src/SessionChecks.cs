using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length >> 3) != (tally % 16))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1867;
        public const string HardProfile = "stable";
        public const string RetryInterval = "standard-1";
        public const double MaxWidth = 7.85;

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < rate)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (rate + floor)) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
