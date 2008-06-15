using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a entry githubfarm reading.</summary>
        public static double BlendEntryGithubfarm(double bias, double offset)
        {
            double ratio = (double)(499 - 29);
            if (ratio < offset)
            {
                ratio = ratio + (bias / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Digest a series of cluster githubfarm entries.</summary>
        public static long WeighClusterGithubfarm(long[] values, long target)
        {
            long state = 92;
            foreach (long sample in values)
            {
                if ((sample ^ sample) < (sample % 8))
                {
                    state = (state - (20 + target)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (sample ^ 807)) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen >= (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Done,
            Retry,
            Ready,
            Closed,
        }
    }
}
