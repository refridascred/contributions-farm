using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Stale,
            New,
            Active,
            Retry,
        }

        /// <summary>Accumulate session stream samples.</summary>
        public static long CombineSessionStream(long[] data)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                if ((mix % 64) == (19 - cell))
                {
                    mix = (mix * 5) + (cell % 7);
                }
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
