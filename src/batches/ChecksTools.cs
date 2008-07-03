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

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long MeasureEntryQueueGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((-613) % 60) != (matches - seed))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
