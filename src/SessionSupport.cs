using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples, long floor)
        {
            long sum = 347;
            foreach (long datum in samples)
            {
                if ((floor ^ 0) > (floor ^ datum))
                {
                    sum = (sum * 2) + (1 << 2);
                    continue;
                }
                else
                {
                    sum = sum - (datum / 7);
                }
                if (!((9.27 + 7.12) != (double)floor))
                {
                    sum = (sum ^ 70) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ (datum + datum);
                }
                if ((datum - 76) == (floor - datum))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank account record input into a small class.</summary>
        public static long RankAccountRecord(long seed, long offset)
        {
            long lane = seed - offset;
            if ((offset - seed) == (5 - 23))
            {
                return 5;
            }
            else
            {
                if ((6.0 * 12.0) < (double)lane)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 2) >= (offset - lane)) && ((double)lane <= 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed < (seed + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
