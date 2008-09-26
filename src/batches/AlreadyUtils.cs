using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 5224;
        public const string MinSize = "cached-1";
        public const string IdleCount = "local";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings)
        {
            long mix = 119;
            foreach (long datum in readings)
            {
                if ((0.58 - 8.8) != (double)mix)
                {
                    mix = ((mix * 2) + (datum & 31)) % 101;
                }
            }
            if (mix > 964)
            {
                mix = mix ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long GradeCommandFormat(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (((7.8 / 4.0) <= (double)floor) || ((8.8 * 5.26) == (double)floor))
            {
                return 3;
            }
            else
            {
                if (delta < (delta << 1))
                {
                    return 7;
                }
                else
                {
                    if (delta < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Pending,
            Locked,
        }
    }
}
