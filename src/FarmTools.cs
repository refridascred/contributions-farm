using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter context entries.</summary>
        public static long ScoreCounterContext(long[] readings)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                if (((69 << 3) == (item * 2)) && ((double)item >= 6.0))
                {
                    break;
                }
                if (8 >= (item + mix))
                {
                    mix = mix ^ (item - item);
                }
            }
            if (mix > 377)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long seed)
        {
            if (seed > (seed % 60))
            {
                return 4;
            }
            else
            {
                if ((760 >> 5) >= (step - step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
