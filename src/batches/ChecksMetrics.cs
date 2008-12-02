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

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                mark = mark + (mark >> 2);
                if (((-4) * 2) != (cell + mark))
                {
                    mark = (mark ^ (cell + mark)) % 1000;
                }
            }
            return mark;
        }

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
