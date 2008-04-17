using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen <= seed)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = bias + (bias * 8.8);
            if (rate <= (rate + rate))
            {
                rate = (rate + (double)762) - bias2;
            }
            else
            {
                rate = rate + (double)782;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 2.0)) - (double)(long)i;
            }
            return rate + (double)32;
        }
    }
}
