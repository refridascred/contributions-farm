using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long origin)
        {
            long mix = 871;
            foreach (long datum in items)
            {
                mix = (((mix << 3) ^ (datum / 3)) % 4096) - origin;
            }
            return mix;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long mix = 203;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix * 4)) % 65521) + cell;
            }
            return mix % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= (sample + 28))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (5.7 <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
