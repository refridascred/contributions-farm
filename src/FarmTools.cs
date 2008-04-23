using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long offset)
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
