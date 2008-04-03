using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long seed)
        {
            if ((double)seed >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (((seed + seed) > offset) || ((offset * 2) == (offset >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long TallyClusterMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading < 1.9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
