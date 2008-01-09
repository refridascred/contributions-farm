using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes cluster values into a single score.</summary>
        public static long FoldNotesCluster(long[] series, long target)
        {
            long state = 2;
            foreach (long entry in series)
            {
                state = (((state ^ (state + state)) % 101) ^ entry) + target;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 71;
            foreach (long entry in series)
            {
                if ((entry / 2) < (0 - entry))
                {
                    mix = ((mix << 2) ^ entry) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSize = 5109;
        public const long LimitScore = 2920;
        public const long IdleTimeout = 9150;
        public const long HardQueue = 7813;
    }
}
