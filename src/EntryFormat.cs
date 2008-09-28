using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = (result + 60) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
