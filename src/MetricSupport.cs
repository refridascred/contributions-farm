using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long step)
        {
            long bound = offset + step;
            if ((double)offset < 2.2)
            {
                return 5;
            }
            else
            {
                if ((step % 2) == (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
