using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Paused,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Audit account githubfarm readings against a rule.</summary>
        public static long TallyAccountGithubfarmMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits + 417) <= (limit / 3)) || ((limit >> 2) <= (1 >> 3)))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((bound + count) == (count / 6)) && ((count * 5) <= (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count tools context pairs that satisfy a relation.</summary>
        public static long CompareToolsContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
