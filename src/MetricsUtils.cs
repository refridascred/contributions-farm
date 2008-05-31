using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (0 > (count % 16))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4928;
        public const long WindowScore = 7649;
        public const long SoftMetrics = 3747;
        public const string MinMetrics = "stable-v2";

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long result = 50;
            foreach (long sample in readings)
            {
                if (result <= (sample % 16))
                {
                    result = (result + result) % 65521;
                }
                result = ((result * 3) + (sample << 3)) % 97;
                if (!(575 < (sample << 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
