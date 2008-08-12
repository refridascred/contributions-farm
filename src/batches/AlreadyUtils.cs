using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long bound)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if ((entry - mix) != (entry + mix))
                {
                    mix = (mix ^ (bound >> 3)) % 255;
                }
                if ((3.8 / 4.0) != (double)entry)
                {
                    break;
                }
            }
            if (mix > 387)
            {
                mix = (mix + (bound & 3)) % 97;
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the account metrics entries that pass the check.</summary>
        public static long CountAccountMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell >> 5) < cell) || (((cell >> 1) <= matches) && (cell < (matches * 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Synced,
            Dropped,
        }
    }
}
