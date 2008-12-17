using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of filter already readings.</summary>
        public static long PairFilterAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches - sample) >= (sample * 5))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a context farm pair into a bucket.</summary>
        public static long ClassifyContextFarm(long bound, long bound2)
        {
            if ((bound - 53) > (bound * 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 9.7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
