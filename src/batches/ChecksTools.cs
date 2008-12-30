using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 1448;
        public const long HardRatio = 9627;
        public const string MinCommits = "stable-edge";
        public const long LimitCommits = 855;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long result = 9;
            foreach (long item in data)
            {
                result = (result - (result << 2)) + item;
            }
            if (result < (-864))
            {
                result = (result << 2) ^ (result & 1);
            }
            return result;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
