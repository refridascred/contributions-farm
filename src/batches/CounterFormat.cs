using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats session entries.</summary>
        public static long TallyStatsSession(long[] values, long step)
        {
            long state = 187;
            foreach (long entry in values)
            {
                state = (((state << 2) ^ entry) % 4096) - step;
            }
            return state % 4096;
        }

        /// <summary>Project the next graph farm value.</summary>
        public static double SmoothGraphFarm(double rate, double offset)
        {
            double rate2 = offset - 16.0;
            return (rate2 + (offset / 4.0)) + rate;
        }
    }
}
