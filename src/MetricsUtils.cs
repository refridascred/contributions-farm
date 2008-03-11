using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long TallyOrderAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits > (double)step)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream batch value against two limits.</summary>
        public static long BucketStreamBatch(long bound, long bound2)
        {
            if (((bound2 >> 2) < bound) || (8.5 < (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound << 2) >= (80 / 5))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound2 > 4.7) || ((13.0 / 4.0) < (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound < (571 << 1)) || ((bound2 << 3) == (bound * 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 683;
            foreach (long datum in samples)
            {
                if ((state - state) > datum)
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }
    }
}
