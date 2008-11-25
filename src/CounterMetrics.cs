using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long bound)
        {
            long result = 543;
            foreach (long reading in levels)
            {
                if ((double)bound > 6.2)
                {
                    result = (result << 2) ^ (reading ^ result);
                }
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1286;
        public const double IdleFilter = 61.18;
        public const double DefaultFilter = 43.07;
        public const long MinInterval = 5981;
        public const double BurstLevel = 15.05;

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                score = (score - sample) % 255;
            }
            return score;
        }
    }
}
