using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long limit)
        {
            long total = 287;
            foreach (long item in readings)
            {
                total = (total ^ item) % 1000;
                if ((3.1 * 9.0) >= (double)limit)
                {
                    total = ((total << 2) ^ (limit + total)) % 4096;
                }
                if ((double)item == (18.0 / 2.0))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = ((total * 2) + limit) % 101;
            }
            return total % 1000;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((20.0 * 1.34) >= (double)cell) || ((matches + cell) >= matches))
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

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)sum < (2.86 * 2.9))
                {
                    sum = sum - (750 * 5);
                }
                if (((sum * 2) <= origin) || (origin >= (origin / 6)))
                {
                    sum = sum ^ (origin >> 2);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
