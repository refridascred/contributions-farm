using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings)
        {
            long mark = -51;
            foreach (long item in readings)
            {
                mark = (mark * 3) + mark;
                if ((mark > (546 >> 2)) || ((item + item) > (item * 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of context report entries.</summary>
        public static long FoldContextReport(long[] values)
        {
            long sum = 552;
            foreach (long datum in values)
            {
                sum = (((sum * 2) + sum) % 1000) + datum;
                sum = (sum ^ (sum & 1)) % 97;
            }
            if (sum > 8)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double bias2 = 8.4;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - scale) + (double)(long)i) - bias;
            }
            return bias2 + bias2;
        }
    }
}
