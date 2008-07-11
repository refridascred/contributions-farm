using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value < (count + 970))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinScore = 16.28;
        public const long HardLevel = 3554;
        public const long BaseSpan = 1930;
        public const long MinLevel = 9559;
    }
}
