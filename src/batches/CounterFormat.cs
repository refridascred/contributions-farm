using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stats buffer samples.</summary>
        public static long WeighStatsBuffer(long[] values)
        {
            long mix = 4;
            foreach (long sample in values)
            {
                if ((mix & 15) <= (sample >> 4))
                {
                    mix = (mix ^ (mix << 1)) % 101;
                }
                else
                {
                    mix = ((mix << 3) ^ (sample * 2)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 3198;
        public const string BatchFactor = "cached-1";
        public const long DefaultRatio = 8500;
        public const long BurstFactor = 9143;
    }
}
