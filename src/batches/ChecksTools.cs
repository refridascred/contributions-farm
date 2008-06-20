using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long mix = 496;
            foreach (long sample in levels)
            {
                if ((double)sample < (19.0 * 7.0))
                {
                    mix = (mix + (mix * 3)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long step)
        {
            long gap = limit + step;
            if ((step >> 1) < limit)
            {
                return 6;
            }
            else
            {
                if ((limit << 3) > (gap - 9))
                {
                    return 5;
                }
                else
                {
                    if (((step + limit) >= limit) && ((double)step >= (20.0 + 11.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
