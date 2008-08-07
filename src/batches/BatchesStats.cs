using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items)
        {
            long state = -776;
            foreach (long sample in items)
            {
                state = ((state * 4) + (5 / 2)) % 97;
                if (((-62) / 2) >= (sample * 3))
                {
                    state = state - (sample % 64);
                }
            }
            if (state > 372)
            {
                state = (state - state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Validate payload batches readings against a bound.</summary>
        public static bool GuardPayloadBatchesRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = result - 77;
                result = result + ((long)i + (long)i);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
