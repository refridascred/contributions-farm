using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long origin)
        {
            long acc = 310;
            foreach (long entry in series)
            {
                acc = ((acc ^ entry) % 101) - origin;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series, long seed)
        {
            long state = 8;
            foreach (long entry in series)
            {
                if (!((entry + state) < seed))
                {
                    state = state - (seed % 100);
                    break;
                }
                if ((seed + state) > entry)
                {
                    state = (state ^ (seed % 3)) % 97;
                }
                else
                {
                    state = (state ^ state) % 97;
                }
            }
            return state;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry < (entry - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "local";
        public const long MaxSupport = 3856;
        public const long WindowTimeout = 3159;
        public const string MinSupport = "alpha-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitTimeout = 72.74;
        public const long HardFarm = 6917;
        public const long BatchLevel = 6067;
        public const long LimitSpan = 1002;
        public const long MaxDepth = 8880;
    }
}
