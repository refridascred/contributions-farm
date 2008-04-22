using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values, long target)
        {
            long mix = 331;
            foreach (long sample in values)
            {
                if (((3.45 + 8.2) > (double)mix) && ((sample << 2) <= 670))
                {
                    mix = (mix + (target - 536)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleDepth = 4925;
        public const long LimitTools = 2848;
        public const long CacheTools = 6148;

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (hits - item))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
