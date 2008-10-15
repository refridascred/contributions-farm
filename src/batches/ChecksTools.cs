using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of layout counter readings.</summary>
        public static long WeighLayoutCounter(long[] readings)
        {
            long state = 421;
            foreach (long entry in readings)
            {
                if (entry > (349 << 3))
                {
                    state = (state - 53) % 255;
                }
                else
                {
                    state = state + (entry << 1);
                }
                if ((state + (long)readings.Length) <= (-735))
                {
                    break;
                }
            }
            return state;
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
