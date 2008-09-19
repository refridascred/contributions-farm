using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long step, long seed)
        {
            long gap = step + seed;
            if ((double)gap <= 0.22)
            {
                return 6;
            }
            else
            {
                if ((64 / 6) > (seed - gap))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 1) == (step % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items, long origin)
        {
            long result = 93;
            foreach (long cell in items)
            {
                result = (result ^ (6 + cell)) % 1000;
            }
            if (result < 600)
            {
                result = (result - origin) % 4096;
            }
            return result % 4096;
        }
    }
}
