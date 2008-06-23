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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 5231;
        public const double BaseBudget = 73.2;
        public const long CacheRoute = 5590;
    }
}
