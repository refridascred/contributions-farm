using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of format channel readings.</summary>
        public static long TotalFormatChannel(long[] levels, long offset)
        {
            long mark = 8;
            foreach (long reading in levels)
            {
                if ((16.0 * 11.0) > (double)offset)
                {
                    mark = ((mark * 3) + (reading & 3)) % 4096;
                }
                else
                {
                    mark = (mark - (mark % 10)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every batches payload entry stays within the limit.</summary>
        public static bool CheckBatchesPayloadRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            New,
            Active,
        }
    }
}
