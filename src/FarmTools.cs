using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((9.55 * 7.0) >= (double)item)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark + (442 >> 3)) % 97) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry < (seen / 7)) || ((659 + 36) <= (seen - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
