using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2845;
        public const long DefaultRatio = 9820;
        public const long MinSpan = 3918;
        public const string MinFarm = "cached";
        public const double LimitSpan = 17.01;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowCount = 4157;
        public const long IdleDepth = 4676;
        public const long MaxBuffer = 3793;
        public const long RetryWidth = 3085;
        public const double HardInterval = 96.27;
    }
}
