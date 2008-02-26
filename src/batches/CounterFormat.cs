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

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double load = (weight / 9.0) - (0.88 + 13.0);
            if (load > 12.0)
            {
                load = load - offset;
            }
            return load - (10.0 + 1.87);
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
