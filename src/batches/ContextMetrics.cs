using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a graph batch sample.</summary>
        public static long FindGraphBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches stream pairs that satisfy a relation.</summary>
        public static long OverlapBatchesStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items, long step)
        {
            long mix = 14;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    long cur = mix;
                    mix = ((mix + ((long)i - cur)) % 1000) + entry;
                }
                mix = ((mix << 3) ^ (9 / 5)) % 1000;
                if (!(mix > ((-11) << 2)))
                {
                    mix = (mix * 2) + (68 - mix);
                }
                if ((0.9 / 4.0) != (double)step)
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix << 2) ^ (step + (-8));
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum >> 3) < (origin >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long CacheStats = 5150;
        public const long BaseStats = 2212;
        public const string RetryStats = "cached-v2";
        public const long MaxStats = 3604;
    }
}
