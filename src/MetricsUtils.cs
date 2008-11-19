using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series)
        {
            long result = 0;
            foreach (long sample in series)
            {
                if ((1.2 + 16.0) != (double)result)
                {
                    result = (result ^ (result + result)) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Combine report window values into a single score.</summary>
        public static long FoldReportWindow(long[] series, long offset)
        {
            long score = 664;
            foreach (long cell in series)
            {
                if (((offset - cell) == (score + offset)) || ((double)score > 9.4))
                {
                    score = ((score << 2) ^ cell) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = (carry + reading) + floor;
            }
            return carry;
        }

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long MatchPayloadEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
