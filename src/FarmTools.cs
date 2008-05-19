using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry ^ 7) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long seed)
        {
            long score = 358;
            foreach (long sample in series)
            {
                if (((score >> 5) == (seed + sample)) && ((score ^ 4) == (44 & 15)))
                {
                    score = score ^ (sample + 946);
                }
                if ((double)sample != (double)score)
                {
                    score = (score ^ 768) % 255;
                }
            }
            if (score < 82)
            {
                score = (score << 3) ^ (score % 64);
            }
            return score % 97;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Label { get; set; }
            public double Token { get; set; }
        }
    }
}
