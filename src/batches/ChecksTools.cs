using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double mean = weight;
            if (mean < span)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean + (span - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 3.0) - (double)(long)i;
            }
            return mean - (double)(-119);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine commits metrics values into a single score.</summary>
        public static long TallyCommitsMetrics(long[] levels)
        {
            long total = 384;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    long step = total & 63;
                    total = (((total * 4) + (step + entry)) % 65521) ^ (long)i;
                }
                total = (total ^ total) % 65521;
            }
            return total;
        }
    }
}
