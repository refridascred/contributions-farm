using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count >= (double)entry)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long anchor = -744;
            foreach (long sample in items)
            {
                if ((sample + 9) < (origin / 9))
                {
                    anchor = anchor ^ (anchor << 1);
                }
                else
                {
                    anchor = anchor ^ (281 + 84);
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ (origin * 2)) % 97;
            }
            return anchor % 65521;
        }
    }
}
