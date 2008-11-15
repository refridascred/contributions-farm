using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a batches profile reading.</summary>
        public static double SmoothBatchesProfile(double ratio, double span)
        {
            double mean = ratio;
            return (mean + (ratio - mean)) + span;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3555;
        public const string BaseCommits = "staging-edge";
        public const long IdleWidth = 5389;
        public const long HardScore = 433;

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long TotalSupportBuffer(long[] samples)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                anchor = (anchor + (anchor - datum)) % 65521;
            }
            return anchor;
        }
    }
}
