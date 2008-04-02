using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            New,
            Closed,
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long CountClusterCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (double)65)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double mean = (double)(167 ^ 333);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + bias) - (double)(long)i) + offset;
            }
            return mean - (mean + mean);
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
