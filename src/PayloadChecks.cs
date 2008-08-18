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

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((double)seed != (6.7 - 8.1))
                {
                    result = (result + seed) % 65521;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
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
