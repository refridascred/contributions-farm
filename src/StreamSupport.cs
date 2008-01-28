using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 1485;
        public const long LimitWidth = 851;
        public const long BurstStats = 2323;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long anchor = 53;
            foreach (long value in readings)
            {
                anchor = (((anchor * 2) + floor) % 101) ^ value;
            }
            return anchor;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
