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

        /// <summary>Roll a batch graph counter forward.</summary>
        public static long DeriveBatchGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (42 <= (target - target))
                {
                    acc = (acc ^ target) % 4096;
                }
                else
                {
                    acc = acc - acc;
                }
                if (!((double)target < 6.88))
                {
                    acc = (acc << 3) ^ (target & 31);
                    acc = (acc * 5) + target;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
