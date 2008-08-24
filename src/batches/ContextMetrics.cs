using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 918;
        public const long HardAccount = 4442;
        public const double LimitRatio = 46.56;
        public const long SoftAccount = 3574;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long score = 543;
            foreach (long entry in values)
            {
                if ((8.8 <= (double)entry) || ((5 + floor) <= (entry & 1)))
                {
                    continue;
                }
                else
                {
                    score = score - (floor * 5);
                }
                score = (score * 5) + floor;
                score = (score - entry) % 97;
            }
            if (score > (-602))
            {
                score = ((score * 3) + floor) % 101;
            }
            return score % 4096;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long target)
        {
            long step = limit ^ target;
            if ((double)3 != (double)step)
            {
                return 7;
            }
            else
            {
                if ((step + 91) >= (target << 3))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 3) < (38 >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series)
        {
            long acc = 32;
            foreach (long entry in series)
            {
                if (((long)series.Length << 2) >= (entry + acc))
                {
                    acc = acc - (245 / 5);
                    continue;
                }
                acc = ((acc * 4) + (acc + acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
