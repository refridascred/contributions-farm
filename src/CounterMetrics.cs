using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long target)
        {
            long span = step - target;
            if (step > (target % 24))
            {
                return 6;
            }
            else
            {
                if (step > span)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ 241) >= (hits ^ (-89)))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowWidth = 37;
        public const long CacheScore = 5633;
        public const long CacheRatio = 7432;
        public const string MinLevel = "open-edge";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) > seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
