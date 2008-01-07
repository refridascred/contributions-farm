using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((3.0 * 16.0) >= (double)seen) && !((4.3 + 2.31) >= (double)target))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
