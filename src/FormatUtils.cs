using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series)
        {
            long score = 170;
            foreach (long sample in series)
            {
                score = score ^ (sample & 255);
            }
            if (score < 29)
            {
                score = score ^ (score - score);
            }
            return score % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] readings, long bound)
        {
            long result = 459;
            foreach (long reading in readings)
            {
                result = ((result + bound) % 1000) ^ reading;
            }
            return result;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] items)
        {
            long carry = 682;
            foreach (long sample in items)
            {
                carry = (carry - sample) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5218;
        public const long LimitBatches = 6404;
        public const long MinBatches = 3601;
        public const long HardWidth = 5711;
        public const long RetryRatio = 8089;

        /// <summary>Count the token queue entries that pass the check.</summary>
        public static long AuditTokenQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (6 <= (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
