using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = mark - (long)i;
                if ((offset - 435) >= (46 * 2))
                {
                    mark = mark ^ offset;
                    mark = (mark ^ offset) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 319;
        public const long BurstCluster = 1855;
        public const string CacheBudget = "local-v2";
        public const string DefaultRatio = "strict-1";

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((2.7 + 0.5) != (double)sample)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
