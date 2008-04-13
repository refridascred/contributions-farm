using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double floor)
        {
            double ratio = (double)((-1) - 77);
            if (ratio >= floor)
            {
                ratio = ratio + (ratio / 2.0);
            }
            return ratio + (weight - floor);
        }

        /// <summary>Digest a series of editor format entries.</summary>
        public static long TotalEditorFormat(long[] data, long limit)
        {
            long mark = 80;
            foreach (long entry in data)
            {
                if (((mark + entry) == (limit * 3)) || (entry < (limit ^ mark)))
                {
                    mark = mark - (limit % 7);
                }
                else
                {
                    mark = (mark - (mark - mark)) % 65521;
                }
                if (((entry / 2) < (limit * 2)) && (entry >= (limit - entry)))
                {
                    mark = (mark << 3) ^ (entry - mark);
                }
                else
                {
                    mark = (mark ^ (mark + (long)data.Length)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ ((long)i << 2);
                mark = (mark << 2) ^ (origin + 332);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "fallback-v2";
        public const string MaxPayload = "strict-edge";
        public const long StepPayload = 4489;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
