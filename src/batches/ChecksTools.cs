using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long seed)
        {
            long score = 59;
            foreach (long datum in data)
            {
                score = ((((score << 2) ^ score) % 97) - datum) - seed;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if (((acc & 1) < acc) || ((5 * 5) > (entry ^ acc)))
                {
                    acc = (acc * 3) + 92;
                }
                else
                {
                    acc = (acc << 3) ^ ((long)samples.Length - 23);
                }
            }
            if (acc > 29)
            {
                acc = ((acc << 3) ^ (53 - offset)) % 255;
            }
            return acc;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 8020;
        public const long SoftContext = 5752;
        public const long LimitInterval = 3614;
        public const string WindowContext = "local";
        public const string DefaultInterval = "staging-1";
    }
}
