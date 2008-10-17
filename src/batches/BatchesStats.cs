using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + step) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long result = 306;
            foreach (long datum in values)
            {
                if (!((73 + result) != (result + result)))
                {
                    result = (result * 4) + 1;
                }
                result = result ^ (datum ^ datum);
            }
            return result;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long target)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if ((item - result) < (item ^ item))
                {
                    result = ((result << 3) ^ item) - target;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Failed,
            Retry,
            Stale,
        }
    }
}
