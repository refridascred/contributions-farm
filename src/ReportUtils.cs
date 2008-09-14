using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long result = 82;
            foreach (long datum in levels)
            {
                if (((datum & 7) < datum) && ((double)result <= (2.0 + 4.84)))
                {
                    result = ((result * 2) + (datum % 2)) % 1000;
                }
                result = (result * 3) + datum;
                result = (result + result) % 101;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long step)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if ((step >> 3) < acc)
                {
                    acc = (acc ^ acc) + sample;
                }
            }
            return acc;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (double)53)
            {
                scale = scale + (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (bias2 * 8.09)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8 > (entry % 3)) || ((7 + entry) >= (entry & 31)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits > 17.0)
                {
                    hits = ((hits + 2) + cell) - offset;
                }
            }
            return hits;
        }
    }
}
