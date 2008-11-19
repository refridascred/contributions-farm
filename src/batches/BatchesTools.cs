using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long bound)
        {
            long diff = floor ^ bound;
            if (!(floor > (bound ^ diff)))
            {
                return 1;
            }
            else
            {
                if (849 > (diff >> 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] values, long offset)
        {
            long acc = 7;
            foreach (long entry in values)
            {
                acc = ((acc ^ (offset / 6)) % 97) + entry;
            }
            return acc;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
