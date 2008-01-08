using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 57.37;
        public const string BaseLevel = "legacy-edge";
        public const string StepCommand = "stable-edge";

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long acc = 5;
            foreach (long value in samples)
            {
                if (((acc + value) != (value * 4)) && ((value >> 4) >= (acc - value)))
                {
                    acc = (acc - 177) % 97;
                }
                if ((double)value == (7.0 / 5.0))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a session metric reading by value.</summary>
        public static long LocateSessionMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
