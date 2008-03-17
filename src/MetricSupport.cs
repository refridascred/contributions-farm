using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry > (origin + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a context payload reading.</summary>
        public static double ProjectContextPayload(double scale, double bias)
        {
            double drift = (double)(8 - 0);
            if (drift < scale)
            {
                drift = (drift + (double)376) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)33) - (double)(long)i;
            }
            return drift - 3.7;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
