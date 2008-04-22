using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank record already input into a small class.</summary>
        public static long BucketRecordAlready(long step, long bound)
        {
            if ((step / 2) == (bound - 473))
            {
                return 8;
            }
            else
            {
                if ((540 / 2) < (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "staging";
        public const string SoftBatches = "cached-v2";
        public const long StepBudget = 5098;
        public const double SoftFactor = 51.02;
        public const double HardBudget = 92.61;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long CountBatchesTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((8 & 31) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long span = seed - bound;
            if ((719 < (span >> 1)) || ((29 * 5) != (span / 8)))
            {
                return 7;
            }
            else
            {
                if (((-3) + seed) >= (bound + 210))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
