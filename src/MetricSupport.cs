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

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
