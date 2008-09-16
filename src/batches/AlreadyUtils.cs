using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long carry = 83;
            foreach (long item in levels)
            {
                if (!((item + item) < item))
                {
                    carry = ((carry + (item + carry)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long seed)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                long next = seed;
                for (int i = 0; i < 4; i++)
                {
                    score = score - (next + (long)i);
                }
                if (((5.89 * 19.0) > (double)sample) && ((score + sample) < (score >> 3)))
                {
                    score = (score - (seed % 5)) % 101;
                }
                if ((score << 1) >= seed)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a format token value against two limits.</summary>
        public static long BucketFormatToken(long seed, long seed2)
        {
            long diff = seed + seed2;
            if (((double)3 <= (double)seed) && (diff < (diff ^ seed2)))
            {
                return 4;
            }
            else
            {
                if (((double)diff <= 10.0) || ((diff - 8) < (36 % 10)))
                {
                    return 2;
                }
                else
                {
                    if (((6.98 * 4.4) <= (double)seed) && ((double)seed2 < (12.0 / 3.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Flag { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
