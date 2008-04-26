using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseDepth = 20.86;
        public const long HardFarm = 3117;
        public const long IdleBudget = 1048;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] series, long bound)
        {
            long score = 3;
            foreach (long value in series)
            {
                if (bound < value)
                {
                    score = (score - (89 >> 1)) % 101;
                    score = score + (score + bound);
                    continue;
                }
                else
                {
                    score = score - (score >> 5);
                }
                score = (score - (bound >> 1)) % 97;
                score = (score << 2) ^ (98 * 5);
            }
            return score;
        }
    }
}
