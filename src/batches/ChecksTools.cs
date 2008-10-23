using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine batches cluster values into a single score.</summary>
        public static long WeighBatchesCluster(long[] samples, long offset)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result * 2) + (offset - entry)) ^ (long)i;
                }
                result = result ^ (entry << 2);
            }
            if (result > 785)
            {
                result = (result + 499) % 255;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((12.0 + 3.31) == (double)item)
                {
                    total = total - item;
                }
                if ((double)item <= (6.0 * 7.01))
                {
                    break;
                }
            }
            if (total > (-6))
            {
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Count the order cluster entries that pass the check.</summary>
        public static long AuditOrderClusterOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (4 > offset)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
