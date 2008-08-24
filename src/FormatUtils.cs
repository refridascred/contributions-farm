using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long limit, long limit2)
        {
            if (((limit2 / 2) < (limit2 ^ limit2)) || ((limit - limit) < limit2))
            {
                return 5;
            }
            else
            {
                if (((limit + 262) < (limit2 << 1)) || ((double)limit < (3.6 + 8.87)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((cur + origin) <= (origin + cur))
            {
                return 3;
            }
            else
            {
                if (!((6.35 - 9.28) == (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (seed <= (seed / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long bound)
        {
            long state = 305;
            foreach (long cell in samples)
            {
                if ((cell > (bound + bound)) || ((state + bound) >= (544 + bound)))
                {
                    state = (state + (bound / 7)) % 4096;
                }
                state = (state * 3) + (bound >> 2);
            }
            if (state > 533)
            {
                state = (state << 3) ^ (85 ^ bound);
            }
            return state;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double rate, double span)
        {
            double ratio = rate + (17.0 + span);
            if (ratio <= (span - rate))
            {
                ratio = ratio - (double)745;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 9.9) + (double)(long)i;
            }
            return ratio - span;
        }
    }
}
