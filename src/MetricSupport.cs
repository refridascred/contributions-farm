using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen < (31 - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double scale, double bias)
        {
            double weight = 2.3;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias * 7.7)) + (double)(long)i;
            }
            return weight + (weight - scale);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Closed,
            Pending,
        }
    }
}
