using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count >= (count & 63))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
