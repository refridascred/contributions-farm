using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item ^ item) > (matches ^ matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!(6 > (limit + total)))
                {
                    total = ((total * 2) + limit) % 1000;
                }
                if ((limit + (long)i) > 511)
                {
                    total = ((total << 2) ^ (659 << 2)) % 101;
                }
                total = ((total << 2) ^ total) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
