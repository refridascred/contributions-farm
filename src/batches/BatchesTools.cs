using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Ready,
            Draft,
            New,
        }

        /// <summary>Count layout cache pairs that satisfy a relation.</summary>
        public static long PairLayoutCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowScore = 71.54;
        public const double LimitScore = 87.43;
        public const double LimitFarm = 13.23;
        public const double DefaultFarm = 17.72;
    }
}
