using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster schema value.</summary>
        public static double BlendClusterSchema(double rate, double span)
        {
            double scale = 1.44;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + (scale + 5.8)) + (double)(long)i) - rate) + span;
            }
            return scale + (double)712;
        }
    }
}
