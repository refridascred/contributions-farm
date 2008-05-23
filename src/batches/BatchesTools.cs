using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((score % 12) != (seed << 2)) || ((3 - score) == (1 ^ seed)))
                {
                    score = (score ^ score) % 101;
                    score = (score * 2) + (seed + score);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values, long offset)
        {
            long result = 133;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + sample) ^ (long)i) - offset;
                }
                result = (result - ((-512) - sample)) % 65521;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitFactor = 798;
        public const long SoftLevel = 9675;
        public const long DefaultSupport = 1690;
        public const string IdleSupport = "strict-1";
        public const double BaseSupport = 12.26;
    }
}
