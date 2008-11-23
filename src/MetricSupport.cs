using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 266;
        public const string SoftRatio = "open-edge";
        public const long HardCluster = 77;
        public const long SoftCluster = 6613;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((9.47 < (double)datum) || ((bound / 3) < bound)) && ((15.0 / 2.0) == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(entry <= (count % 97)) || ((7.94 * 2.0) < (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
