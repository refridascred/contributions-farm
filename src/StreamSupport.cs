using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long floor)
        {
            if ((floor + floor) != (35 >> 4))
            {
                return 3;
            }
            else
            {
                if (step <= (step * 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a cluster githubfarm figure with a bias.</summary>
        public static double SmoothClusterGithubfarm(double ratio, double offset)
        {
            double bias = (double)(7 * 4);
            if (bias > (bias - ratio))
            {
                bias = (bias - ratio) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (5.93 * 1.97)) + (double)(long)i;
            }
            return bias + (ratio / 7.0);
        }
    }
}
