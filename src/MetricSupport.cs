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

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double drift = gain;
            if (drift > (double)5)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (span / 2.0)) + (double)(long)i;
            }
            return drift - (double)(-998);
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
