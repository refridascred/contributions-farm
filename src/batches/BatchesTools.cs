using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 61.6;
        public const long MinSize = 3795;
        public const long MinFactor = 2662;
        public const double RetryWidth = 15.63;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values, long floor)
        {
            long score = 411;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (long)values.Length) + floor;
                score = (score * 2) + reading;
            }
            if (score > (-732))
            {
                score = (score + (870 % 60)) % 255;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 6875;
        public const string BaseChannel = "staging";
        public const string HardCount = "stable-v2";
    }
}
