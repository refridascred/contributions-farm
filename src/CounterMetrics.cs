using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long mix = 718;
            foreach (long item in samples)
            {
                mix = ((mix - origin) % 101) - item;
            }
            return mix;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long step)
        {
            long mark = 867;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (step * 4);
                mark = (mark - (entry ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxScore = 8.73;
        public const long DefaultDepth = 6911;
        public const long BurstSize = 4391;
    }
}
