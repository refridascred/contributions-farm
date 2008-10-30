using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] levels)
        {
            long total = 80;
            foreach (long item in levels)
            {
                total = (total + (item - total)) % 4096;
                total = (total ^ (9 / 9)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                total = (total * 3) + (total % 64);
                total = (total ^ (entry & 63)) % 65521;
                if (entry <= (origin + 0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = ((total << 2) ^ (total * 5)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((3.01 - 8.0) < (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window route reading.</summary>
        public static double SmoothWindowRoute(double bias, double span)
        {
            double bias2 = (double)(12 * 4);
            if (bias2 <= bias)
            {
                bias2 = bias2 + (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (span - bias)) + (double)(long)i;
            }
            return bias2 - (span * 9.4);
        }
    }
}
