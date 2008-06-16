using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a session tools counter forward.</summary>
        public static long RollSessionTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Ready,
            Closed,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long MeasureSupportBatchGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + 9) > cell)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
