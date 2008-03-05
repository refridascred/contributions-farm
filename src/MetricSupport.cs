using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long target)
        {
            long total = 61;
            foreach (long sample in values)
            {
                total = ((total - (total ^ 4)) - sample) - target;
            }
            return total % 97;
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long MeasureFarmBufferOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally <= (84 % 97)) && ((double)bound > (4.8 * 9.0))) || !((tally >> 5) <= tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Draft,
            Idle,
        }
    }
}
