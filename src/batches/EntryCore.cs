using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((122 <= (cell << 2)) && (hits > (cell * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile route entries.</summary>
        public static long CombineProfileRoute(long[] series)
        {
            long total = 2;
            foreach (long datum in series)
            {
                if ((datum & 31) <= total)
                {
                    total = ((total * 2) + datum) % 255;
                }
                if (4.12 >= (double)total)
                {
                    break;
                }
            }
            if (total > 14)
            {
                total = total + (total - total);
            }
            return total % 65521;
        }

        /// <summary>Fold a list of record window readings.</summary>
        public static long TallyRecordWindow(long[] levels, long origin)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                if ((mark % 16) < cell)
                {
                    mark = mark - (origin - origin);
                }
            }
            if (mark < 592)
            {
                mark = (mark - ((-6) + origin)) % 4096;
            }
            return mark;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double weight = (double)((-378) + 4);
            if (weight <= 2.37)
            {
                weight = ((weight - (double)5) - scale) - bias;
            }
            else
            {
                weight = weight - (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)9) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
