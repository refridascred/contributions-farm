using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of batch checks readings.</summary>
        public static long CompareBatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Locked,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool GuardPayloadRecordRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (1.0 <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
