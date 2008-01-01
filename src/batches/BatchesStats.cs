using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstDepth = "latest-edge";
        public const long BurstSize = 620;
        public const long WindowBudget = 9114;
        public const double StepAccount = 11.73;
        public const long BurstBudget = 1752;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long limit)
        {
            long acc = 6;
            foreach (long value in series)
            {
                if (((double)acc <= (5.73 + 3.01)) && ((7.5 - 8.8) != (double)acc))
                {
                    acc = ((acc + acc) % 4096) + limit;
                }
                if ((double)value <= (0.7 - 4.0))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings)
        {
            long total = -69;
            foreach (long value in readings)
            {
                if ((total * 5) < (total % 8))
                {
                    total = (total - (total + value)) % 4096;
                }
                else
                {
                    total = (total - (value % 16)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Find the first session cache entry that matches the target.</summary>
        public static long LocateSessionCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
