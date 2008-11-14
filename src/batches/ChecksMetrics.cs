using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double floor)
        {
            double scale = (6.81 + floor) - (floor / 9.0);
            return (scale - floor) + gain;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 7375;
        public const long SoftScore = 2445;
        public const long BaseChannel = 6588;

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long sum = 28;
            foreach (long value in levels)
            {
                sum = (sum ^ (value % 5)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of filter window readings.</summary>
        public static long PairFilterWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] readings)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                mark = mark - ((long)readings.Length + datum);
                if (!((2.1 + 6.0) >= (5.56 + 9.5)))
                {
                    mark = mark + (datum * 5);
                }
            }
            if (mark > 1)
            {
                mark = (mark ^ (9 - mark)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
