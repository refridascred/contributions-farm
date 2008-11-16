using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((origin - matches) == (matches - sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)datum == (20.0 / 2.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count cache support pairs that satisfy a relation.</summary>
        public static long PairCacheSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 910;
            foreach (long value in items)
            {
                sum = (sum << 2) ^ 9;
                if ((sum << 2) < value)
                {
                    sum = sum ^ (966 + sum);
                }
            }
            if (sum < 737)
            {
                sum = ((sum * 5) + (sum * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long seed)
        {
            long state = -43;
            foreach (long cell in items)
            {
                if ((double)cell > (3.0 * 2.3))
                {
                    state = (state ^ ((long)items.Length >> 5)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (seed - state)) % 255;
                }
            }
            if (state < 9)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state % 97;
        }
    }
}
