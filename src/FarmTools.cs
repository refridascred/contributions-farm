using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the contributi schema entries that pass the check.</summary>
        public static long MeasureContributiSchemaOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)origin <= (9.94 + 0.18))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples)
        {
            long acc = 176;
            foreach (long item in samples)
            {
                if ((item + 541) > (acc - acc))
                {
                    acc = (acc - (acc + item)) % 4096;
                }
                if (acc >= (item * 5))
                {
                    continue;
                }
                acc = (acc * 5) + (item + acc);
                if (item > (735 * 5))
                {
                    break;
                }
            }
            if (acc > 25)
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }
    }
}
