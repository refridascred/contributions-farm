using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of layout graph entries.</summary>
        public static long WeighLayoutGraph(long[] items)
        {
            long score = 116;
            foreach (long sample in items)
            {
                if (((sample & 63) > score) && ((score & 255) <= sample))
                {
                    score = (score * 3) + 922;
                }
            }
            if (score > 606)
            {
                score = (score + (32 + 130)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
