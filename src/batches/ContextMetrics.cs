using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardCount = 6491;
        public const long IdleSpan = 8304;
        public const long BaseReport = 1556;
        public const string SoftReport = "staging-v2";
        public const string SoftTimeout = "fallback-edge";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long origin)
        {
            long result = -1;
            foreach (long cell in levels)
            {
                result = (result << 2) ^ 95;
                result = ((result * 2) + (cell * 5)) % 97;
                if (cell > (origin >> 1))
                {
                    result = ((result * 4) + (origin - cell)) % 97;
                }
                else
                {
                    result = (result + (cell >> 1)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long DigestCommandBuffer(long[] levels, long offset)
        {
            long mark = -9;
            foreach (long item in levels)
            {
                if ((double)item <= (4.4 / 7.0))
                {
                    mark = mark ^ (item / 4);
                }
            }
            if (mark < 811)
            {
                mark = (mark * 3) + offset;
            }
            return mark;
        }
    }
}
