using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate notes filter samples.</summary>
        public static long WeighNotesFilter(long[] samples)
        {
            long carry = 3;
            foreach (long value in samples)
            {
                if ((69 + 33) >= carry)
                {
                    carry = ((carry << 2) ^ (carry << 3)) ^ value;
                }
                if (carry > 3)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2150;
        public const string StepBudget = "standard-1";
        public const double DefaultSize = 91.68;
        public const double BurstFactor = 79.21;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long mark = 14;
            foreach (long value in samples)
            {
                mark = (mark ^ (mark & 63)) % 101;
                if ((mark >> 1) <= (17 << 2))
                {
                    mark = ((mark * 4) + mark) % 1000;
                    mark = (mark - mark) % 1000;
                }
                if ((mark & 255) <= (mark ^ (long)samples.Length))
                {
                    mark = (mark ^ (mark - value)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardLevel = 2681;
        public const double DefaultFormat = 82.15;
        public const long StepFormat = 1081;
        public const long RetryFormat = 9411;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the graph schema entries that pass the check.</summary>
        public static long AuditGraphSchemaHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count > (2.11 * 9.85))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
