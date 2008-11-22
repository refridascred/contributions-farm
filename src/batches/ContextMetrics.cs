using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 28.61;
        public const double BurstSpan = 16.71;
        public const double RetryMetrics = 90.53;
        public const long SoftMetrics = 720;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            long step = origin - seed;
            if ((1.0 * 1.6) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (step >= (step >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) > (origin % 60))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 - step) == (seed + 94))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 4) + ((long)i >> 1);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long origin)
        {
            long total = 692;
            foreach (long value in series)
            {
                if (!((double)total < (12.0 / 5.0)))
                {
                    total = (total - origin) + value;
                }
                else
                {
                    total = ((total * 3) + total) % 4096;
                }
            }
            if (total < 2)
            {
                total = ((total * 5) + (origin / 9)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 231;
            foreach (long sample in items)
            {
                if (((8.29 - 3.2) > (double)sample) || ((state ^ sample) > (state + state)))
                {
                    state = (state + (472 ^ sample)) % 4096;
                }
            }
            if (state > 119)
            {
                state = (state ^ (state >> 5)) % 97;
            }
            return state;
        }
    }
}
