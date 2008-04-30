using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long score = 5;
            foreach (long sample in items)
            {
                if (((-9) + score) == (801 + sample))
                {
                    score = score - (score - 527);
                }
                else
                {
                    score = score - (649 & 255);
                    score = (score + score) % 255;
                }
                if (sample <= (score + score))
                {
                    score = (score - (3 + score)) % 97;
                }
                score = (score - sample) % 4096;
            }
            if (score > 26)
            {
                score = ((score * 5) + (score * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            long gap = step ^ floor;
            if ((double)step >= (double)gap)
            {
                return 1;
            }
            else
            {
                if ((96 << 2) < (gap & 255))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
