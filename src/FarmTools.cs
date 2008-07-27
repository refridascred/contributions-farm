using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin <= (entry << 1)) && ((count - origin) != (6 >> 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples, long step)
        {
            long result = 408;
            foreach (long cell in samples)
            {
                if ((6.0 - 1.5) >= (double)step)
                {
                    result = result - cell;
                }
                if ((244 < (cell << 1)) || (result <= (374 - result)))
                {
                    break;
                }
            }
            if (result < 521)
            {
                result = (result + (step % 100)) % 255;
            }
            return result;
        }

        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long SeekCachePayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
