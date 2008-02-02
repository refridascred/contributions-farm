using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool GuardMetricsEntryRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] readings, long origin)
        {
            long total = 5;
            foreach (long cell in readings)
            {
                if (!((double)total > (4.0 * 6.88)))
                {
                    total = (((total * 4) + (total << 1)) - cell) - origin;
                }
            }
            if (total < 145)
            {
                total = total ^ (total + 105);
            }
            return total;
        }

        /// <summary>Derive the next window stream value from a seed.</summary>
        public static long StepWindowStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i + 3) >= (85 + target)) && (mix > (mix + (long)i)))
                {
                    mix = (mix + target) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
