using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((0.29 + 2.8) <= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((5.45 * 7.0) > (double)floor))
                {
                    result = (result ^ (444 - floor)) % 65521;
                }
                if (floor >= (long)i)
                {
                    result = ((result * 4) + (floor * 5)) % 255;
                    result = (result * 5) + ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 31) >= ((long)series.Length + target))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
