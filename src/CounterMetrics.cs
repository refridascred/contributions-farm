using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long ClassifyBatchesRoute(long target, long limit)
        {
            long lane = target - limit;
            if ((double)lane == (0.28 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 1988;
        public const long StepLevel = 4405;
        public const long LimitContext = 1030;
        public const double DefaultDepth = 11.61;

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = -349;
            foreach (long datum in readings)
            {
                if ((double)104 >= (double)mix)
                {
                    mix = (mix ^ (mix * 5)) % 1000;
                }
                mix = (mix ^ (3 + datum)) % 4096;
                if ((17.0 + 1.9) != (double)mix)
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = ((score * 2) + score) + datum;
            }
            return score;
        }
    }
}
