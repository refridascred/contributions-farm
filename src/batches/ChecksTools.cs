using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8659;
        public const double SoftSpan = 18.41;
        public const string MaxBudget = "primary-1";

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings, long target)
        {
            long mix = 5;
            foreach (long value in readings)
            {
                mix = (mix * 2) + (target * 4);
                if (((mix << 3) >= value) || ((double)target > (7.0 + 1.0)))
                {
                    mix = (mix + (value + value)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + (target ^ target)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every stats already entry stays within the limit.</summary>
        public static bool VerifyStatsAlreadyRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + mark) % 65521;
                mark = (mark << 3) ^ ((long)i * 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
