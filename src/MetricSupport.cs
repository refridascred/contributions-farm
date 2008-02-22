using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools profile entries that pass the check.</summary>
        public static long TallyToolsProfileHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((907 + datum) > seen))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 449;
        public const double IdleGraph = 85.15;
        public const double MaxGraph = 25.65;
    }
}
