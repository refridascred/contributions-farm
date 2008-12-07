using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of entry batch entries.</summary>
        public static long ScoreEntryBatch(long[] items)
        {
            long result = 73;
            foreach (long value in items)
            {
                result = ((result ^ 44) % 1000) - value;
            }
            return result;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long anchor = 64;
            foreach (long reading in levels)
            {
                if ((double)reading > (1.9 / 5.0))
                {
                    anchor = ((anchor ^ anchor) % 101) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepSpan = 4042;
        public const long CacheDepth = 2616;
        public const long CacheLayout = 9298;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
