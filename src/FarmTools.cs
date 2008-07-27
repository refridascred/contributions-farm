using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin <= (entry << 1)) && ((count - origin) != (6 >> 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ seed;
                result = ((result << 2) ^ ((-20) >> 1)) % 101;
                result = result - ((long)i << 1);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ offset) > offset)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
