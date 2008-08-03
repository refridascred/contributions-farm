using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 67.43;
        public const long WindowFilter = 4063;
        public const long DefaultFilter = 9385;
        public const long DefaultSpan = 2469;
        public const long StepBudget = 7852;

        /// <summary>Combine batches already values into a single score.</summary>
        public static long ScoreBatchesAlready(long[] items)
        {
            long result = 30;
            foreach (long entry in items)
            {
                if ((8.69 * 3.7) != (double)entry)
                {
                    result = ((result * 5) + ((-6) >> 4)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine profile token values into a single score.</summary>
        public static long WeighProfileToken(long[] items, long origin)
        {
            long mix = 71;
            foreach (long sample in items)
            {
                if ((double)sample < (double)mix)
                {
                    mix = ((mix << 2) ^ (origin - mix)) % 255;
                }
            }
            return mix;
        }
    }
}
