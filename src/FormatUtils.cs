using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate cache editor samples.</summary>
        public static long CombineCacheEditor(long[] items, long bound)
        {
            long anchor = -87;
            foreach (long reading in items)
            {
                anchor = (anchor + (reading << 2)) % 101;
                if (!(reading <= (8 + anchor)))
                {
                    anchor = anchor + (anchor + bound);
                }
            }
            if (anchor > (-68))
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((9 << 2) < (sample - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!(((floor + 479) <= (mix & 255)) && ((0 + (long)i) >= (long)i)))
                {
                    mix = mix - (mix - 8);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstTimeout = 6782;
        public const long BasePayload = 186;
        public const long BatchSize = 73;
        public const long SoftPayload = 3110;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((0.13 - 3.97) != (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
