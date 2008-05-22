using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long TallyLayoutGithubfarmMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (bound < (sample * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double span)
        {
            double ratio2 = (double)((-4) + 2);
            if (ratio2 > (span * 0.6))
            {
                ratio2 = (ratio2 - (double)2) - ratio;
            }
            return ratio2 - (double)89;
        }
    }
}
