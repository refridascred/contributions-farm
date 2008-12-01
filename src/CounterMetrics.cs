using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batch report series from a seed.</summary>
        public static long IterateBatchReport(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if (!(((double)(long)i <= (18.0 * 5.8)) && (822 <= target)))
                {
                    total = (total ^ ((-83) + total)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((double)seen != (2.9 / 3.0)) || !((cell - origin) != (origin * 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long CountLayoutEditorHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((228 << 2) != (count / 4))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Count stats window pairs that satisfy a relation.</summary>
        public static long MatchStatsWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
