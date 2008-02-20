using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double scale = span;
            if (scale < (scale + ratio))
            {
                scale = scale + (double)98;
            }
            else
            {
                scale = scale + (span * 18.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)530;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double mean = (span - gain) + (gain + span);
            if (mean > gain)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
