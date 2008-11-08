using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 71.42;
        public const long StepInterval = 1654;
        public const double BurstChannel = 14.55;
        public const long LimitChannel = 8186;
        public const long HardTimeout = 8757;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
