using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                sum = ((sum + (sum - sum)) % 97) - sample;
            }
            if (sum > 83)
            {
                sum = ((sum << 3) ^ (471 + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
