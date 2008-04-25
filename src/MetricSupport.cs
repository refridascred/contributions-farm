using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] readings, long origin)
        {
            long result = 901;
            foreach (long item in readings)
            {
                if (origin < (item + 78))
                {
                    result = result ^ ((long)readings.Length % 8);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowDepth = "legacy-v2";
        public const double SoftSpan = 26.76;
        public const long BaseMetrics = 7553;
        public const long BurstMetrics = 330;
    }
}
