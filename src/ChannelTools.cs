using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long origin)
        {
            if (((origin + seed) < origin) || ((0.09 / 9.0) > (double)seed))
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= (double)(-37)))
                {
                    return 2;
                }
                else
                {
                    if ((6.0 - 6.4) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (limit % 10);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
