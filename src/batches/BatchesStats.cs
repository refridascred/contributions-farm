using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4751;
        public const double RetrySize = 93.08;
        public const string StepTimeout = "local-v2";

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((46 ^ (long)i) <= anchor) && ((double)limit >= (6.0 * 6.6)))
                {
                    anchor = ((anchor << 2) ^ (4 / 6)) % 97;
                    anchor = anchor ^ 77;
                    continue;
                }
                anchor = (anchor * 2) + limit;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 4141;
        public const long CacheFactor = 9179;
        public const long SoftBatches = 9758;
    }
}
