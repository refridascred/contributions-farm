using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                double weight = (3.93 + 13.0) / 5.0;
                if ((double)score < (1.48 + weight))
                {
                    weight = weight - 3.96;
                }
                else
                {
                    weight = weight - 9.98;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((double)origin == (double)188)
            {
                return 8;
            }
            else
            {
                if (offset >= delta)
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) == (161 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long origin)
        {
            long result = 541;
            foreach (long entry in data)
            {
                if (((result * 4) >= entry) && ((origin - (long)data.Length) < (entry / 3)))
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 61)
            {
                result = (result - (origin + result)) % 255;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "strict-1";
        public const string IdleStats = "latest";
        public const long MaxSize = 579;
        public const long RetryTimeout = 9557;
        public const string BurstStats = "latest";
    }
}
