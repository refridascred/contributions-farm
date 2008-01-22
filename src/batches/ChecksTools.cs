using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks already samples are out of range.</summary>
        public static long MeasureChecksAlreadyOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + 10) >= (sample - 11))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data)
        {
            long score = 95;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (98 - score)) % 97;
                if ((double)value != (2.97 - 15.0))
                {
                    break;
                }
            }
            if (score < 89)
            {
                score = (score << 3) ^ 46;
            }
            return score;
        }
    }
}
