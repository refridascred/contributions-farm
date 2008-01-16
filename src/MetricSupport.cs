using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 3373;
        public const long SoftSize = 8796;
        public const long WindowChannel = 970;
        public const long CacheSize = 7086;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSize = 5412;
        public const long HardBuffer = 5026;
        public const string SoftBuffer = "open";
        public const double LimitBuffer = 72.13;
        public const long DefaultBuffer = 3790;
    }
}
