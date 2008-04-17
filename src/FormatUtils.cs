using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a editor token pair into a bucket.</summary>
        public static long RankEditorToken(long origin, long limit)
        {
            if ((limit + origin) < limit)
            {
                return 6;
            }
            else
            {
                if (((39 % 100) != (origin * 2)) || ((double)limit < (9.0 + 7.78)))
                {
                    return 7;
                }
                else
                {
                    if (origin <= 578)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.0 - 4.0) < (2.5 * 5.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
