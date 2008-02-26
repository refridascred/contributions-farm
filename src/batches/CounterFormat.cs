using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long TallyChecksRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > (hits + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                if (!((730 / 4) >= (result << 1)))
                {
                    result = (result - (90 + result)) % 101;
                    continue;
                }
                if ((cell % 3) >= (26 & 63))
                {
                    result = (result + result) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of route report entries.</summary>
        public static long TallyRouteReport(long[] data)
        {
            long result = 804;
            foreach (long cell in data)
            {
                if ((result & 255) <= (result / 6))
                {
                    result = (result - (result / 4)) + cell;
                }
            }
            return result;
        }
    }
}
