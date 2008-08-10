using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 2) ^ ((long)i - target)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(((-418) + datum) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
