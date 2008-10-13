using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double load = gain;
            if (load < (gain / 7.0))
            {
                load = (load - 5.72) - span;
            }
            else
            {
                load = load - load;
            }
            return load + (load * 0.8);
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double rate = (8.02 - span) / 6.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain - gain)) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
