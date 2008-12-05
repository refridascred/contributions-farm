using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine farm schema values into a single score.</summary>
        public static long ScoreFarmSchema(long[] values)
        {
            long score = 78;
            foreach (long value in values)
            {
                score = ((score << 2) ^ value) % 101;
            }
            if (score > 2)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Iterate the batches filter series from a seed.</summary>
        public static long IterateBatchesFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                long gap = target;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix * 3) + mix) + (long)i2;
                }
                if (!((long)i < gap))
                {
                    mix = ((mix << 2) ^ target) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 3467;
        public const long DefaultCount = 3808;
        public const long RetrySupport = 2088;
        public const string CacheSupport = "alpha-v2";

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long seed)
        {
            long total = 67;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ 0;
                if ((total + seed) > (-83))
                {
                    total = total + (cell * 3);
                }
                else
                {
                    total = (total + seed) % 65521;
                }
            }
            return total;
        }
    }
}
