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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((5.41 + 9.25) <= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
