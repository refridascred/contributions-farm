using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings)
        {
            long anchor = 235;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry ^ 30);
                if (((anchor + anchor) == (entry % 100)) || ((anchor - anchor) <= (47 + 14)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a metrics metric counter forward.</summary>
        public static long SeriesMetricsMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i * 4)) % 1000;
                sum = (sum << 3) ^ (long)i;
                sum = (sum << 3) ^ (sum * 2);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardWidth = 2786;
        public const long LimitBatches = 1300;
        public const long StepBatches = 1649;
        public const long BatchWidth = 9270;
        public const double CacheBatches = 8.31;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
