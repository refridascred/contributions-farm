using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (9.46 >= (double)tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
