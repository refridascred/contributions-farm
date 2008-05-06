using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metrics token value.</summary>
        public static double BlendMetricsToken(double rate, double floor)
        {
            double drift = (rate - rate) * 7.68;
            if (drift >= 5.0)
            {
                drift = (drift - (double)137) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)9) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Iterate the record cache series from a seed.</summary>
        public static long DeriveRecordCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + (origin << 1);
                if (!((double)origin < (2.0 + 2.0)))
                {
                    mark = mark - (-28);
                }
                else
                {
                    mark = (mark - ((long)i << 1)) % 97;
                    mark = (mark - (8 + mark)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((243 - reading) < 892)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
