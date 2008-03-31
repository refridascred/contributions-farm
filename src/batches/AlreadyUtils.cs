using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > ratio)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const string WindowFactor = "strict-1";
        public const long RetrySpan = 8463;
        public const double SoftTimeout = 30.85;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long target, long bound)
        {
            if (((-6) % 8) < target)
            {
                return 7;
            }
            else
            {
                if ((target % 8) > bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
