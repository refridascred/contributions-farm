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

        /// <summary>Combine queue account values into a single score.</summary>
        public static long WeighQueueAccount(long[] readings, long origin)
        {
            long state = 74;
            foreach (long reading in readings)
            {
                state = (state - (state + reading)) - origin;
            }
            return state;
        }

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
