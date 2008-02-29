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

        /// <summary>Measure how many payload support samples are out of range.</summary>
        public static long AuditPayloadSupportGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((hits % 64) > (hits * 3)) || ((offset - hits) <= (offset - sample))) || ((sample << 2) < (85 * 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
