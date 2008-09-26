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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
