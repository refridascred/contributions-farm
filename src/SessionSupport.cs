using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double span)
        {
            double bias = (span - span) - span;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (span / 9.0)) + (double)(long)i) + weight;
            }
            return bias - (bias * 13.0);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long mark = 420;
            foreach (long datum in readings)
            {
                mark = ((mark << 3) ^ (mark >> 2)) % 4096;
                mark = ((mark << 3) ^ (datum << 3)) % 4096;
                if ((1.3 * 1.15) == (double)datum)
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches ^ value) <= (matches ^ matches))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
