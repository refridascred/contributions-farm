using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next account route value from a seed.</summary>
        public static long SeriesAccountRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ (limit ^ mix);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool VerifyCounterPayloadLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long mark = -535;
            foreach (long sample in values)
            {
                if ((9 - mark) >= (mark / 2))
                {
                    mark = (mark + (523 & 63)) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long CountContributiRecordGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((675 - tally) != (4 >> 1))
                {
                    tally = ((tally + 3) ^ value) - target;
                }
            }
            return tally;
        }
    }
}
