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

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double drift = (floor * 6.5) * 10.0;
            if (drift > drift)
            {
                drift = drift + (double)577;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight + drift)) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
