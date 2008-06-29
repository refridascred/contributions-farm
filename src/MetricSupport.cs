using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowLevel = "alpha";
        public const long LimitBatch = 4265;
        public const double BaseBudget = 45.46;
        public const long SoftBatch = 8116;

        /// <summary>Look up the position of a stats notes sample.</summary>
        public static long LookupStatsNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((mix - 2) == (seed + 72))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
