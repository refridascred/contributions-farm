using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long sum = 0;
            foreach (long sample in items)
            {
                if (((origin / 7) < origin) && ((sample + origin) >= origin))
                {
                    sum = sum ^ (49 >> 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum << 3) ^ (bound - bound);
                sum = (sum << 3) ^ sum;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((1.1 / 8.0) != (double)limit) && (((limit >> 4) != (cell * 2)) && ((12 / 5) > (limit >> 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long mark = 521;
            foreach (long datum in readings)
            {
                if ((datum + mark) > (datum * 4))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((mark - datum) <= mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
