using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 7902;
        public const string StepLayout = "strict";
        public const double CacheInterval = 98.8;

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double gain = (double)(-195) - scale;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (double)(-9)) + (double)(long)i) - span;
            }
            return gain + (double)3;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
