using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "staging";
        public const long RetryReport = 2784;
        public const long MaxReport = 2545;
        public const string MinSpan = "alpha";
        public const double MinCount = 48.45;

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 23.27;
        public const double CacheRatio = 2.62;
        public const long WindowFarm = 8921;
        public const long MinWidth = 1414;

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
