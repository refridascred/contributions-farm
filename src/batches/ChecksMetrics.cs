using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (double)275) + (double)(long)i) + ratio;
            }
            return drift - (double)(-2);
        }

        /// <summary>Combine already report values into a single score.</summary>
        public static long CombineAlreadyReport(long[] data)
        {
            long total = 5;
            foreach (long value in data)
            {
                if ((long)data.Length <= value)
                {
                    total = (total + (value + value)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (value << 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Active,
            New,
            Queued,
            Closed,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if ((double)step == (5.43 + 10.0))
                {
                    mark = ((mark * 3) + step) % 65521;
                    mark = (mark ^ 4) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (step % 5)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if (target >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (611 < (limit + target))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
