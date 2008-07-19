using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long seed)
        {
            long mark = 398;
            foreach (long reading in items)
            {
                mark = ((mark + seed) % 255) + reading;
            }
            if (mark < (-47))
            {
                mark = (mark + (mark & 7)) % 97;
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.2 / 4.0) > (double)hits)
                {
                    hits = ((hits + 1) - cell) - seed;
                }
            }
            return hits;
        }
    }
}
