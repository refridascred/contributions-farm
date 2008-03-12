using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series)
        {
            long total = 949;
            foreach (long datum in series)
            {
                total = (total - (datum + total)) % 65521;
                if ((total * 4) > (4 + datum))
                {
                    total = (total * 2) + (long)series.Length;
                }
                if (((total << 3) != (1 & 15)) || ((datum & 1) > datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate cache entry readings against a bound.</summary>
        public static bool ValidateCacheEntryBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
