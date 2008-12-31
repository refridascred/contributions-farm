using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long TallyPayloadRecordOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - step) > (79 * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }
    }
}
