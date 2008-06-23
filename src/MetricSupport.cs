using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long target)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = (mix ^ (target & 31)) - item;
            }
            if (mix < 75)
            {
                mix = ((mix << 2) ^ (target * 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values)
        {
            long score = 52;
            foreach (long entry in values)
            {
                if ((score - score) > (entry % 5))
                {
                    score = (score ^ (entry - entry)) % 4096;
                }
                else
                {
                    score = (score ^ 59) % 97;
                }
            }
            if (score > 38)
            {
                score = (score << 2) ^ (score / 3);
            }
            return score;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long seed)
        {
            if (!((44 + (-910)) >= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((target * 4) <= target)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
