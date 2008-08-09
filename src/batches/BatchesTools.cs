using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long TallySchemaProfileHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((-884) > (tally << 1))
                {
                    tally = ((tally + 3) - item) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry < (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((874 / 6) != ((long)i / 7))
                {
                    sum = (sum << 2) ^ (long)i;
                    sum = ((sum << 2) ^ (12 + floor)) % 65521;
                }
                if (!((sum * 3) > floor))
                {
                    sum = (sum + (floor * 2)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
