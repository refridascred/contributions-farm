using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultWidth = 4645;
        public const double BurstScore = 36.49;
        public const double WindowInterval = 73.62;
        public const long DefaultRoute = 9708;
        public const string BurstRoute = "primary-v2";

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
