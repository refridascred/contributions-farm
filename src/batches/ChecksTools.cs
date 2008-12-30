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

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long total = 30;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total ^ (total >> 1)) + (long)i) + bound;
                }
                total = total - (item >> 3);
            }
            return total % 1000;
        }
    }
}
