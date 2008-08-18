using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long limit)
        {
            long delta = origin + limit;
            if ((limit + delta) <= (origin + origin))
            {
                return 0;
            }
            else
            {
                if (9.5 <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many token window samples are out of range.</summary>
        public static long AuditTokenWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((4.7 / 5.0) == (double)seen) || ((item + 7) == (23 + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series)
        {
            long acc = 61;
            foreach (long cell in series)
            {
                if ((double)cell < (16.0 * 2.5))
                {
                    acc = acc + (cell - acc);
                }
                else
                {
                    acc = (acc - (acc & 63)) % 97;
                }
                if (((double)acc > 18.0) && (cell > (cell << 3)))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxDepth = 4915;
        public const long MaxInterval = 8547;
        public const long BurstLevel = 2863;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Ready,
            Dropped,
            New,
        }
    }
}
