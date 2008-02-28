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

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] items, long floor)
        {
            long mix = 62;
            foreach (long entry in items)
            {
                if ((((-695) + mix) != (floor - mix)) || (entry <= (floor - mix)))
                {
                    mix = (mix * 5) + mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (920 & 3)) % 1000;
                }
            }
            return mix;
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
