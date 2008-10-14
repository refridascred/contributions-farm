using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 171;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score * 2) + ((long)i + score)) % 101;
                }
                score = ((score * 5) + (datum % 97)) % 1000;
            }
            if (score > 806)
            {
                score = score ^ (score ^ 88);
            }
            return score;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Active,
            Locked,
            Done,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Stale,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultFactor = 437;
        public const long BatchSpan = 2657;
        public const long IdleTimeout = 2767;
        public const long LimitFactor = 4393;
        public const long DefaultRatio = 4594;
    }
}
