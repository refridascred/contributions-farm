using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool GuardTokenCacheRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (2 << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((3.8 * 9.4) < (double)cell) && ((cell ^ tally) == (cell & 127))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
