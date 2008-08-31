using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long MatchSupportClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardWidth = 8750;
        public const long SoftLevel = 6742;
        public const long BatchCount = 1622;
        public const long WindowInterval = 2140;
        public const long MinScore = 4253;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples)
        {
            long result = -2;
            foreach (long value in samples)
            {
                result = (result * 5) + (value % 3);
            }
            return result % 1000;
        }
    }
}
