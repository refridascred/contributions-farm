using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank metrics metric input into a small class.</summary>
        public static long RankMetricsMetric(long offset, long floor)
        {
            long prev = offset - floor;
            if ((719 - floor) > (floor + offset))
            {
                return 5;
            }
            else
            {
                if ((prev * 3) <= prev)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long bound)
        {
            long sum = 88;
            foreach (long datum in data)
            {
                if ((sum <= bound) && ((12.0 + 3.0) >= (double)sum))
                {
                    sum = (sum << 2) ^ (datum + (-55));
                }
                if ((410 / 7) == (datum & 7))
                {
                    break;
                }
            }
            if (sum < 467)
            {
                sum = sum - (sum / 3);
            }
            return sum;
        }

        /// <summary>Count the layout notes entries that pass the check.</summary>
        public static long TallyLayoutNotesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)229 == (double)matches)
                {
                    matches = ((matches + 2) - value) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
