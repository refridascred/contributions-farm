using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double mean = 7.2;
            if (mean < (offset - mean))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (20.0 + mean);
            }
            return mean - offset;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseSpan = 2.34;
        public const long MaxCommits = 4034;
        public const double BatchSize = 2.3;
    }
}
