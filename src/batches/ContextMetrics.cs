using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long RankBatchesCache(long seed, long step)
        {
            long step2 = seed + step;
            if ((seed <= (seed & 31)) || ((step2 + step) != (step2 + step2)))
            {
                return 5;
            }
            else
            {
                if (((double)step >= (9.7 / 8.0)) || ((833 ^ step) <= (30 >> 4)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long step)
        {
            if (((step % 8) >= (bound ^ 54)) || ((double)bound >= 7.0))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) > (step + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((step % 60) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 3) > (step / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            Retry,
            Closed,
            Active,
            New,
        }
    }
}
