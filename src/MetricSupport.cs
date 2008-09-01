using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches & 127) != (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((((datum << 2) > (count + count)) && (count >= datum)) || !((21 - (long)data.Length) > datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultTimeout = 949;
        public const long HardFactor = 1874;
        public const long BaseLevel = 39;
        public const long MaxCount = 9253;
    }
}
