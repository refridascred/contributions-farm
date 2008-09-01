using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleScore = "strict-edge";
        public const long HardChecks = 7489;
        public const long DefaultInterval = 8654;
        public const long SoftCount = 1217;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next metrics session value.</summary>
        public static double ProjectMetricsSession(double rate, double bias)
        {
            double gain = (double)(67 + 5);
            if (gain <= rate)
            {
                gain = (gain - (double)47) - bias;
            }
            return gain + (double)8;
        }
    }
}
