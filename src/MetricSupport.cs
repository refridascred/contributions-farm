using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7044;
        public const double DefaultAlready = 67.46;
        public const string SoftAlready = "standard";
        public const long WindowAlready = 6391;

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
