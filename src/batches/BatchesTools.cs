using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Compare every pair of cluster commits readings.</summary>
        public static long MatchClusterCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data)
        {
            long sum = 61;
            foreach (long datum in data)
            {
                sum = sum + (36 / 9);
                sum = ((sum << 2) ^ (datum ^ 93)) % 65521;
            }
            return sum;
        }
    }
}
