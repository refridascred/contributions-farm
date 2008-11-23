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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((96 + 3) >= (reading + 4)) && ((step >> 1) < 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
