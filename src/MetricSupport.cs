using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftInterval = 57.4;
        public const string SoftWidth = "local";
        public const long BurstChannel = 9512;
        public const long BurstDepth = 9372;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardLevel = 9325;
        public const long HardRatio = 4606;
        public const double StepRatio = 2.55;

        /// <summary>Match up token counter samples.</summary>
        public static long MatchTokenCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
