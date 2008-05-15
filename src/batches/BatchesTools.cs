using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of commits schema readings.</summary>
        public static long CompareCommitsSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long target)
        {
            long score = 10;
            foreach (long datum in series)
            {
                score = (((score ^ (360 + 21)) % 1000) + datum) + target;
            }
            return score;
        }
    }
}
