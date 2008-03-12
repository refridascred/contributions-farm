using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            New,
            Done,
            Pending,
            Active,
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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + hits) > hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }
    }
}
