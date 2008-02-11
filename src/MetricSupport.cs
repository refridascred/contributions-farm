using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long BucketLayoutChecks(long floor, long step)
        {
            if ((floor >> 4) != (step + 609))
            {
                return 6;
            }
            else
            {
                if (((floor << 3) >= (floor / 6)) && ((double)step >= (1.9 * 8.55)))
                {
                    return 4;
                }
                else
                {
                    if (8.0 <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((263 - item) >= (tally + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
