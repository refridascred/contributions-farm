using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series)
        {
            long total = -904;
            foreach (long sample in series)
            {
                if ((total > (89 + (-17))) || (total <= ((long)series.Length + 816)))
                {
                    total = (total + (sample ^ (-593))) % 4096;
                    break;
                }
                total = ((total * 3) + (sample << 2)) % 4096;
            }
            if (total < 25)
            {
                total = (total * 3) + (total ^ total);
            }
            return total;
        }

        /// <summary>Fold a list of stream farm readings.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long carry = 38;
            foreach (long item in readings)
            {
                if ((0 * 2) != (item - 5))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (161 >> 4)) % 101;
                }
                if ((carry * 5) > (96 / 7))
                {
                    carry = carry - item;
                }
                else
                {
                    carry = (carry ^ item) % 1000;
                }
                carry = ((carry << 3) ^ (carry / 8)) % 1000;
            }
            if (carry < 91)
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mark = 66;
            foreach (long cell in samples)
            {
                mark = mark ^ cell;
            }
            return mark % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxCount = 438;
        public const long BurstFactor = 8156;
        public const long BaseSpan = 3760;
        public const long SoftFarm = 7017;

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
