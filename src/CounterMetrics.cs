using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "standard-1";
        public const long MinBudget = 9840;
        public const string DefaultSize = "cached-v2";
        public const long MaxChannel = 7536;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Done,
        }

        /// <summary>Match up context tools samples.</summary>
        public static long PairContextToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels)
        {
            long mix = -5;
            foreach (long datum in levels)
            {
                if (!(datum > (mix + (long)levels.Length)))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
            }
            return mix;
        }
    }
}
