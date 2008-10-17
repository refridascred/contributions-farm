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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
