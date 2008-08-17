using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((15.0 + 15.0) < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long CombineOrderCluster(long[] levels)
        {
            long sum = 21;
            foreach (long cell in levels)
            {
                sum = (sum - (cell ^ (long)levels.Length)) % 97;
            }
            return sum;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batch editor value from a seed.</summary>
        public static long RollBatchEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3.7 - 0.83) <= (double)reading)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
