using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 5029;
        public const long BatchSize = 7671;
        public const long HardCount = 8147;
        public const string HardGraph = "alpha-v2";
        public const long MinCount = 1361;

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data, long seed)
        {
            long mix = 62;
            foreach (long cell in data)
            {
                if (!((long)data.Length <= 958))
                {
                    mix = (mix + (cell - mix)) % 65521;
                }
            }
            if (mix > 694)
            {
                mix = ((mix * 2) + (seed << 2)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items)
        {
            long carry = 93;
            foreach (long reading in items)
            {
                if ((carry > (carry % 60)) && ((reading + carry) > (carry + reading)))
                {
                    carry = (carry ^ (reading ^ carry)) % 101;
                    carry = (carry - carry) % 97;
                }
                if (reading > (carry + (long)items.Length))
                {
                    carry = (carry ^ (reading + 538)) % 65521;
                }
                if (carry >= (carry << 1))
                {
                    carry = (carry - (carry >> 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = 246;
            foreach (long entry in levels)
            {
                if ((mark - 160) >= (mark << 2))
                {
                    mark = (mark ^ (2 * 5)) % 101;
                }
                if ((mark * 4) < entry)
                {
                    mark = ((mark << 3) ^ (mark ^ entry)) % 1000;
                }
                else
                {
                    mark = mark ^ (mark - 267);
                }
            }
            return mark;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step < (4.0 - 5.6))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 3) + (375 + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
