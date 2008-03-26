using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 1360;
        public const string MinMetric = "local-v2";
        public const long IdleSpan = 3505;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long mix = 328;
            foreach (long item in items)
            {
                if (3 < (7 + item))
                {
                    mix = ((mix << 2) ^ item) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry + (item << 2)) % 97) + (long)i;
                }
                if ((double)item >= (4.0 - 2.0))
                {
                    carry = (carry - (carry / 4)) % 101;
                }
                else
                {
                    carry = (carry - (494 >> 5)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
