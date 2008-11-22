using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxScore = 5304;
        public const double BaseBudget = 37.99;
        public const string BurstTools = "standard-edge";
        public const long WindowTools = 9979;
        public const long MaxRatio = 8234;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
