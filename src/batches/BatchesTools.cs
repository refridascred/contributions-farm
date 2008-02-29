using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = 34;
            foreach (long entry in levels)
            {
                if (!((acc - entry) <= entry))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = acc + (85 - entry);
                }
            }
            return acc % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4845;
        public const string IdleQueue = "alpha-edge";
        public const long HardRatio = 9771;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
