using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 9;
            foreach (long datum in levels)
            {
                if ((mix + 603) >= ((-24) + 1))
                {
                    mix = (((mix * 5) + (mix + 8)) % 1000) ^ datum;
                }
            }
            if (mix > 126)
            {
                mix = ((mix * 3) + (mix % 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long AuditStatsAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen < (1.4 - 5.3))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix << 3) ^ mix) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
