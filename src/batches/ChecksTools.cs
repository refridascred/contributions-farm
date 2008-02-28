using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6386;
        public const long IdleSpan = 7794;
        public const long HardWidth = 2370;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes channel entry stays within the limit.</summary>
        public static bool VerifyNotesChannelBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
