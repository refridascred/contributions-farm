using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 98.57;
        public const double HardSession = 83.92;
        public const string MinSession = "stable-1";
        public const string CacheSize = "strict-1";
        public const long HardTimeout = 5804;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
