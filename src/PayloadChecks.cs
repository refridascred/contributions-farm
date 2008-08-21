using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long score = 968;
            foreach (long entry in items)
            {
                if (6.6 > (double)entry)
                {
                    score = (score * 4) + (entry - (long)items.Length);
                }
            }
            if (score < 28)
            {
                score = (score + (score & 255)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Iterate the format batches series from a seed.</summary>
        public static long DeriveFormatBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = (result - ((-4) << 2)) % 255;
                if (!((90 - (long)i) > (long)i))
                {
                    result = ((result * 2) + seed) % 101;
                    result = (result << 3) ^ (result * 3);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 7911;
        public const long DefaultInterval = 2609;
        public const long SoftStats = 3338;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count >> 5) != (count % 7))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 84;
            foreach (long value in data)
            {
                if ((double)sum >= (9.7 * 2.23))
                {
                    sum = ((sum ^ (sum / 8)) % 65521) + value;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "stable-v2";
        public const long DefaultReport = 3483;
        public const long MinInterval = 374;
        public const long StepTimeout = 5563;
    }
}
