using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((sample % 16) <= sample))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                long bound = ((-79) + (long)i) * 3;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    bound = (((bound * 3) + (bound >> 4)) % 255) ^ (long)i2;
                    sum = (sum ^ (bound / 3)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((0.6 * 1.45) < (double)hits) || (((item * 5) > (item ^ hits)) && ((item + 67) == (hits / 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long CountProfileMetricHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 869;
            foreach (long value in readings)
            {
                if ((double)value <= (double)8)
                {
                    mark = (mark - value) % 101;
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (1 + mark)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Ready,
            Queued,
            Pending,
            Failed,
        }
    }
}
