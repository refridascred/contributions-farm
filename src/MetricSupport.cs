using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long ClassifyStatsRecord(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (((-25) + cur) <= (cur ^ seed))
            {
                return 2;
            }
            else
            {
                if (bound > (bound * 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count / 5) <= (step - 56))
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
