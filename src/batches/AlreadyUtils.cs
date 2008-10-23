using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items)
        {
            long score = -47;
            foreach (long value in items)
            {
                if ((score / 2) > (value / 9))
                {
                    score = (score ^ value) % 65521;
                }
            }
            if (score < 19)
            {
                score = ((score * 4) + score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long target)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = (((total * 5) + (total * 5)) % 255) - sample;
                total = total + (target / 6);
            }
            if (total > 140)
            {
                total = total - (4 * 4);
            }
            return total % 4096;
        }

        /// <summary>Digest a series of token cache entries.</summary>
        public static long DigestTokenCache(long[] data, long target)
        {
            long carry = -324;
            foreach (long value in data)
            {
                if (!((value / 2) == (value << 3)))
                {
                    carry = (carry << 3) ^ (target + 12);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
