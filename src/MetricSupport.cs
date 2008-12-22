using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a window layout reading by value.</summary>
        public static long FindWindowLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstLevel = 671;
        public const double StepFactor = 64.57;
        public const long BatchStream = 9639;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
