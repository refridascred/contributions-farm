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

        /// <summary>Roll a layout cache counter forward.</summary>
        public static long StepLayoutCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
