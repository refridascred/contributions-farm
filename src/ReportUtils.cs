using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (count % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a support metrics reading by value.</summary>
        public static long LocateSupportMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
