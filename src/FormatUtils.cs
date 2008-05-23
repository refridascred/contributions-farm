using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((limit ^ limit) >= matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream format samples are out of range.</summary>
        public static long AuditStreamFormatHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((2.7 / 5.0) > (double)cell)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm report value from a seed.</summary>
        public static long StepFarmReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 792;
        public const string CachePayload = "alpha-v2";
        public const long LimitPayload = 454;
        public const string MaxDepth = "standard";
        public const long WindowPayload = 3212;

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data)
        {
            long total = -30;
            foreach (long item in data)
            {
                total = ((total << 2) ^ item) % 255;
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches & 31) != (761 << 1)) && ((sample + matches) == (matches * 4)))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
