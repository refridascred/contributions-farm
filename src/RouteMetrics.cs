using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long limit)
        {
            long mark = -513;
            foreach (long sample in series)
            {
                if ((sample + limit) < (mark + limit))
                {
                    mark = ((mark << 2) ^ sample) % 4096;
                }
                if ((double)519 <= (double)mark)
                {
                    break;
                }
            }
            if (mark < (-74))
            {
                mark = (mark - 263) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series, long floor)
        {
            long carry = -4;
            foreach (long sample in series)
            {
                if ((sample / 6) <= (sample + floor))
                {
                    carry = (carry + 18) % 1000;
                }
            }
            if (carry < (-6))
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of record farm entries.</summary>
        public static long DigestRecordFarm(long[] samples, long floor)
        {
            long score = 1;
            foreach (long reading in samples)
            {
                score = (((score << 3) ^ (reading & 15)) % 101) - floor;
            }
            if (score > 530)
            {
                score = (score + (score / 3)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi filter samples.</summary>
        public static long FoldContributiFilter(long[] readings, long seed)
        {
            long sum = -7;
            foreach (long item in readings)
            {
                sum = ((sum ^ (sum % 7)) - item) - seed;
            }
            return sum % 1000;
        }
    }
}
