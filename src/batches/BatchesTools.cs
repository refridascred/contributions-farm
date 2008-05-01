using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up checks cluster samples.</summary>
        public static long CompareChecksClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph stats value from a seed.</summary>
        public static long RollGraphStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + ((long)i * 2)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 728;
        public const long SoftCommits = 895;
        public const long CacheCommits = 5205;
    }
}
