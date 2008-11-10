using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleWidth = 8775;
        public const long MinContext = 2927;
        public const long StepContext = 5386;
        public const long DefaultSpan = 7270;
        public const long DefaultCount = 1658;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Paused,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - count) > (limit >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
