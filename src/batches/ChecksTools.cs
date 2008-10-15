using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double ratio, double floor)
        {
            double weight = (14.0 - floor) / 2.0;
            if (weight > (double)5)
            {
                weight = (weight - (double)89) - ratio;
            }
            else
            {
                weight = weight - floor;
            }
            return weight - (3.4 - weight);
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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
